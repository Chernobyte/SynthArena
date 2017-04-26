using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelectInfoPanel : MonoBehaviour {

    public int playerId;

    public Image CharacterIcon;
    public Image CharacterIconFrame;
    public Image WeaponIcon;
    public Image WeaponIconFrame;
    public Image Ability1Icon;
    public Image Ability1IconFrame;
    public Image Ability2Icon;
    public Image Ability2IconFrame;

    public Text CharacterName;
    public Text WeaponText;
    public Text MoveTextHeader;
    public Text AimTextHeader;
    public Text JumpText;
    public Text Ability1TextHeader;
    public Text Ability1Text;
    public Text Ability2TextHeader;
    public Text Ability2Text;

    public Image MoveStick;
    public Image AimStick;
    public Image WeaponButton;
    public Image JumpButton;
    public Image Ability1Button;
    public Image Ability2Button;

    public GameObject ParentInfoObject;
    public Text InactiveText;
    
    public static Color NeutralColor = Color.gray;

    private Color playerColor;

    void Start ()
    {
        playerColor = PlayerColor.GetColorFromId(playerId);

        DisplayInactiveInfo();
	}
	
	void Update ()
    {
		
	}

    public void DisplayInactiveInfo()
    {
        SetActiveColor();

        InactiveText.gameObject.GetComponent<Text>().enabled = true;

        ParentInfoObject.gameObject.SetActive(false);
    }

    public void DisplayCharacterInfo(CharacterInfo data)
    {
        SetActiveColor();

        InactiveText.gameObject.GetComponent<Text>().enabled = false;

        ParentInfoObject.gameObject.SetActive(true);

        CharacterIcon.sprite = data.characterModel;
        WeaponIcon.sprite = data.weaponIcon;
        Ability1Icon.sprite = data.ability1Icon;
        Ability2Icon.sprite = data.ability2Icon;

        CharacterName.text = data.characterName;
        WeaponText.text = data.weaponName;
        JumpText.text = data.jumpName;
        Ability1Text.text = data.ability1Name;
        Ability2Text.text = data.ability2Name;
    }

    public void DisplayConfirmInfo(CharacterInfo data)
    {
        SetNeutralColor();

        InactiveText.gameObject.GetComponent<Text>().enabled = false;

        ParentInfoObject.gameObject.SetActive(true);

        CharacterIcon.sprite = data.characterModel;
        WeaponIcon.sprite = data.weaponIcon;
        Ability1Icon.sprite = data.ability1Icon;
        Ability2Icon.sprite = data.ability2Icon;

        CharacterName.text = data.characterName;
        WeaponText.text = data.weaponName;
        JumpText.text = data.jumpName;
        Ability1Text.text = data.ability1Name;
        Ability2Text.text = data.ability2Name;
    }

    private void SetActiveColor()
    {
        CharacterIcon.color = Color.white;
        WeaponIcon.color = Color.white;
        Ability2Icon.color = Color.white;
        Ability1Icon.color = Color.white;

        MoveStick.color = Color.white;
        AimStick.color = Color.white;
        WeaponButton.color = Color.white;
        JumpButton.color = Color.white;
        Ability1Button.color = Color.white;
        Ability2Button.color = Color.white;

        CharacterIconFrame.color = playerColor;
        WeaponIconFrame.color = playerColor;
        Ability1IconFrame.color = playerColor;
        Ability2IconFrame.color = playerColor;
        CharacterName.color = playerColor;
        WeaponText.color = playerColor;
        MoveTextHeader.color = playerColor;
        AimTextHeader.color = playerColor;
        Ability1Text.color = playerColor;
        Ability2Text.color = playerColor;
        JumpText.color = playerColor;
        Ability1TextHeader.color = playerColor;
        Ability2TextHeader.color = playerColor;
        

        InactiveText.color = playerColor;
    }

    private void SetNeutralColor()
    {
        CharacterIcon.color = NeutralColor;
        WeaponIcon.color = NeutralColor;
        Ability2Icon.color = NeutralColor;
        Ability1Icon.color = NeutralColor;

        MoveStick.color = NeutralColor;
        AimStick.color = NeutralColor;
        WeaponButton.color = NeutralColor;
        JumpButton.color = NeutralColor;
        Ability1Button.color = NeutralColor;
        Ability2Button.color = NeutralColor;

        CharacterIconFrame.color = NeutralColor;
        WeaponIconFrame.color = NeutralColor;
        Ability1IconFrame.color = NeutralColor;
        Ability2IconFrame.color = NeutralColor;
        CharacterName.color = NeutralColor;
        WeaponText.color = NeutralColor;
        MoveTextHeader.color = NeutralColor;
        AimTextHeader.color = NeutralColor;
        Ability1Text.color = NeutralColor;
        Ability2Text.color = NeutralColor;
        JumpText.color = NeutralColor;
        Ability1TextHeader.color = NeutralColor;
        Ability2TextHeader.color = NeutralColor;

        InactiveText.color = NeutralColor;
    }
}
