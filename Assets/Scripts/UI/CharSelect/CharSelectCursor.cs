using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class CharSelectCursor : MonoBehaviour {

    public int playerId;

    private PlayerIndex playerIndex;
    private GamePadState gamePadState;
    private GamePadState previousGamePadState;
    private float repeatCooldown = 0.2f;
    private CharSelectOverlord overlord;
    private CharacterInfo[] characterSelectOptions;
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
    }
	
	void Update()
    {
        HandleInput();
        HandlePosition();
	}

    public void Init(CharSelectOverlord overlord, CharacterInfo[] characterSelectOptions, CharSelectInfoPanel panel)
    {
        this.overlord = overlord;
        this.characterSelectOptions = characterSelectOptions;
        this.panel = panel;
        this.playerIndex = XInputDotNetHelpers.MapPlayerIdToPlayerIndex(playerId);
    }

    private enum CharSelectAction { Up, Down }

    private enum CharSelectState { Inactive, Selecting, Ready }

    void HandleInput()
    {
        gamePadState = GamePad.GetState(playerIndex);

        //get controller state
        controllerState.x = gamePadState.ThumbSticks.Left.X;
        controllerState.y = gamePadState.ThumbSticks.Left.Y;

        var confirmState = gamePadState.Buttons.A;
        var previousConfirmState = previousGamePadState.Buttons.A;
        bool confirmReceived, confirmStopped;
        XInputDotNetHelpers.MapButtonStateToReceivedStopped(confirmState, previousConfirmState, out confirmReceived, out confirmStopped);

        var revertState = gamePadState.Buttons.B;
        var previousRevertState = previousGamePadState.Buttons.B;
        bool revertReceived, revertStopped;        
        XInputDotNetHelpers.MapButtonStateToReceivedStopped(revertState, previousRevertState, out revertReceived, out revertStopped);

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
                overlord.PlayConfirmSound();
            }
            else if (state == CharSelectState.Selecting)
            {
                var targetCharacterSelect = characterSelectOptions[currentCharSelectIndex];
                overlord.ConfirmSelection(this, targetCharacterSelect, targetCharacterSelect.characterPrefab);
                state = CharSelectState.Ready;
                updatePosition = true;
                overlord.PlayConfirmSound();
            }
        }
        else if (revertReceived)
        {
            if (state == CharSelectState.Ready)
            {
                overlord.CancelSelection(this);
                state = CharSelectState.Selecting;
                updatePosition = true;
                overlord.PlayRevertSound();
            }
            else if (state == CharSelectState.Selecting)
            {
                state = CharSelectState.Inactive;
                updatePosition = true;
                overlord.PlayRevertSound();
            }
        }

        previousGamePadState = gamePadState;
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

        overlord.PlaySelectSound();

        updatePosition = false;
    }
}
