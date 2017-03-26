using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

    public int playerId;
    public float repeatCooldown = 0.5f;

    private InputController gamepad;
    private CharSelectOverlord overlord;
    private Vector2 controllerState;
    private float lastActionTime;
    private CharSelectAction lastAction;
    private bool updatePosition = false;

    private GameObject[] characterSelectOptions;
    private int currentIndex;

    void Start()
    {
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

    public void Init(CharSelectOverlord overlord, GameObject[] characterSelectOptions)
    {
        this.overlord = overlord;
        this.characterSelectOptions = characterSelectOptions;
        updatePosition = true;
    }

    private enum CharSelectAction { Up, Down }

    void HandleInput()
    {
        //get controller state
        controllerState.x = gamepad.Move_X();
        controllerState.y = gamepad.Move_Y();

        var confirmReceived = gamepad.A();
        var revertReceived = gamepad.B();

        var timeSinceLastAction = Time.time - lastActionTime;

        if (controllerState.y < 0)
        {
            if (lastAction != CharSelectAction.Down || timeSinceLastAction > repeatCooldown)
            {
                lastAction = CharSelectAction.Down;
                lastActionTime = Time.time;
                currentIndex = (currentIndex + 1) % characterSelectOptions.Length;
                updatePosition = true;
            }
        }
        else if (controllerState.y > 0)
        {
            if (lastAction != CharSelectAction.Up || timeSinceLastAction > repeatCooldown)
            {
                lastAction = CharSelectAction.Up;
                lastActionTime = Time.time;
                if (currentIndex == 0)
                    currentIndex = characterSelectOptions.Length - 1;
                else
                    currentIndex = (currentIndex - 1) % characterSelectOptions.Length;
                updatePosition = true;
            }
        }

        if (confirmReceived)
        {
            overlord.ConfirmCursor(this);
        }
        else if (revertReceived)
        {
            overlord.CancelCursor(this);
        }
    }

    void HandlePosition()
    {
        if (!updatePosition)
            return;

        var targetCharacterSelect = characterSelectOptions[currentIndex];
        gameObject.transform.position = targetCharacterSelect.transform.position;

        updatePosition = false;
    }
}
