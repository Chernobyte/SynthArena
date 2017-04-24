using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelectInfoPanel : MonoBehaviour {

    public int playerId;

    public Image CharacterIcon;
    public Image CharacterIconFrame;
    public Image Ability1Icon;
    public Image Ability1IconFrame;
    public Image Ability2Icon;
    public Image Ability2IconFrame;
    public Text CharacterName;
    public Text WeaponTextHeader;
    public Text WeaponText;
    public Text Ability1TextHeader;
    public Text Ability1Text;
    public Text Ability2TextHeader;
    public Text Ability2Text;

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
        Ability1Icon.sprite = data.ability1Icon;
        Ability2Icon.sprite = data.ability2Icon;

        CharacterName.text = data.characterName;
        WeaponText.text = data.weaponName;
        Ability1Text.text = data.ability1Name;
        Ability2Text.text = data.ability2Name;
    }

    public void DisplayConfirmInfo(CharacterInfo data)
    {
        SetNeutralColor();

        InactiveText.gameObject.GetComponent<Text>().enabled = false;

        ParentInfoObject.gameObject.SetActive(true);

        CharacterIcon.sprite = data.characterModel;
        Ability1Icon.sprite = data.ability1Icon;
        Ability2Icon.sprite = data.ability2Icon;

        CharacterName.text = data.characterName;
        WeaponText.text = data.weaponName;
        Ability1Text.text = data.ability1Name;
        Ability2Text.text = data.ability2Name;
    }

    private void SetActiveColor()
    {
        CharacterIcon.color = Color.white;
        Ability2Icon.color = Color.white;
        Ability1Icon.color = Color.white;
        
        CharacterIconFrame.color = playerColor;
        Ability1IconFrame.color = playerColor;
        Ability2IconFrame.color = playerColor;
        CharacterName.color = playerColor;
        WeaponText.color = playerColor;
        Ability1Text.color = playerColor;
        Ability2Text.color = playerColor;
        WeaponTextHeader.color = playerColor;
        Ability1TextHeader.color = playerColor;
        Ability2TextHeader.color = playerColor;

        InactiveText.color = playerColor;
    }

    private void SetNeutralColor()
    {
        CharacterIcon.color = NeutralColor;
        Ability2Icon.color = NeutralColor;
        Ability1Icon.color = NeutralColor;

        CharacterIconFrame.color = NeutralColor;
        Ability1IconFrame.color = NeutralColor;
        Ability2IconFrame.color = NeutralColor;
        CharacterName.color = NeutralColor;
        WeaponText.color = NeutralColor;
        Ability1Text.color = NeutralColor;
        Ability2Text.color = NeutralColor;
        WeaponTextHeader.color = NeutralColor;
        Ability1TextHeader.color = NeutralColor;
        Ability2TextHeader.color = NeutralColor;

        InactiveText.color = NeutralColor;
    }
}
