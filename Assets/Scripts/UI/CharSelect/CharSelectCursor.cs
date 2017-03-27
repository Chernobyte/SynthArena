using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectCursor : MonoBehaviour {

    public int playerId;

    private float repeatCooldown = 0.2f;
    private InputController gamepad;
    private CharSelectOverlord overlord;
    private CharacterIconData[] characterSelectOptions;
    private CharSelectInfoPanel panel;
    private Vector2 controllerState;
    private int currentCharSelectIndex;
    private float lastActionTime;
    private CharSelectAction lastAction;
    private bool updatePosition = false;
    private CharSelectState state = CharSelectState.Inactive;
    private Vector3 initialPosition;

    
    

    void Start()
    {
        initialPosition = gameObject.transform.position;

        switch (playerId)
        {
            case 1: gamepad = new InputController(ControllerNumber.ONE); break;
            case 2: gamepad = new InputController(ControllerNumber.TWO); break;
            case 3: gamepad = new InputController(ControllerNumber.THREE); break;
            case 4: gamepad = new InputController(ControllerNumber.FOUR); break;
        }
    }
	
	void Update()
    {
        HandleInput();
        HandlePosition();
	}

    public void Init(CharSelectOverlord overlord, CharacterIconData[] characterSelectOptions, CharSelectInfoPanel panel)
    {
        this.overlord = overlord;
        this.characterSelectOptions = characterSelectOptions;
        this.panel = panel;
    }

    private enum CharSelectAction { Up, Down }

    private enum CharSelectState { Inactive, Selecting, Ready }

    void HandleInput()
    {
        //get controller state
        controllerState.x = gamepad.Move_X();
        controllerState.y = gamepad.Move_Y();

        var confirmReceived = gamepad.A();
        var revertReceived = gamepad.B();

        var timeSinceLastAction = Time.time - lastActionTime;

        if (state == CharSelectState.Selecting)
        {
            if (controllerState.y < 0)
            {
                if (lastAction != CharSelectAction.Down || timeSinceLastAction > repeatCooldown)
                {
                    lastAction = CharSelectAction.Down;
                    lastActionTime = Time.time;
                    currentCharSelectIndex = (currentCharSelectIndex + 1) % characterSelectOptions.Length;
                    updatePosition = true;
                }
            }
            else if (controllerState.y > 0)
            {
                if (lastAction != CharSelectAction.Up || timeSinceLastAction > repeatCooldown)
                {
                    lastAction = CharSelectAction.Up;
                    lastActionTime = Time.time;
                    if (currentCharSelectIndex == 0)
                        currentCharSelectIndex = characterSelectOptions.Length - 1;
                    else
                        currentCharSelectIndex = (currentCharSelectIndex - 1) % characterSelectOptions.Length;
                    updatePosition = true;
                }
            }
        }

        if (confirmReceived)
        {
            if (state == CharSelectState.Inactive)
            {
                state = CharSelectState.Selecting;
                updatePosition = true;
            }
            else if (state == CharSelectState.Selecting)
            {
                overlord.ConfirmCursor(this);
                state = CharSelectState.Ready;
                updatePosition = true;
            }
        }
        else if (revertReceived)
        {
            if (state == CharSelectState.Ready)
            {
                overlord.CancelCursor(this);
                state = CharSelectState.Selecting;
                updatePosition = true;
            }
            else if (state == CharSelectState.Selecting)
            {
                state = CharSelectState.Inactive;
                updatePosition = true;
            }
        }
    }

    void HandlePosition()
    {
        if (!updatePosition)
            return;

        var targetCharacterSelect = characterSelectOptions[currentCharSelectIndex];

        if (state == CharSelectState.Inactive)
        {
            gameObject.transform.position = initialPosition;
            panel.DisplayInactiveInfo();
        }
        else if (state == CharSelectState.Ready)
        {
            gameObject.transform.position = initialPosition;
            panel.DisplayConfirmInfo(targetCharacterSelect);
        }
        else if (state == CharSelectState.Selecting)
        {
            gameObject.transform.position = targetCharacterSelect.transform.position;
            panel.DisplayCharacterInfo(targetCharacterSelect);
        }

        updatePosition = false;
    }
}
