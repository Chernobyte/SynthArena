using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelectInfoPanel : MonoBehaviour {

    public int playerId;

    public Image CharacterModel;
    public Image Ability1;
    public Image Ability2;
    public Image Weapon;

    public Text InactiveText;
    public Image ReadyFilter; 

    void Start ()
    {
        DisplayInactiveInfo();
	}
	
	void Update ()
    {
		
	}

    public void DisplayInactiveInfo()
    {
        InactiveText.gameObject.SetActive(true);
        CharacterModel.gameObject.SetActive(false);
        Ability1.gameObject.SetActive(false);
        Ability2.gameObject.SetActive(false);
        Weapon.gameObject.SetActive(false);
        ReadyFilter.gameObject.SetActive(false);
    }

    public void DisplayCharacterInfo(CharacterIconData data)
    {
        InactiveText.gameObject.SetActive(false);
        CharacterModel.gameObject.SetActive(true);
        Ability1.gameObject.SetActive(true);
        Ability2.gameObject.SetActive(true);
        Weapon.gameObject.SetActive(true);
        ReadyFilter.gameObject.SetActive(false);

        CharacterModel.sprite = data.CharacterModel;
        Ability1.sprite = data.Ability1;
        Ability2.sprite = data.Ability2;
        Weapon.sprite = data.Weapon;
    }

    public void DisplayConfirmInfo(CharacterIconData data)
    {
        InactiveText.gameObject.SetActive(false);
        CharacterModel.gameObject.SetActive(true);
        Ability1.gameObject.SetActive(true);
        Ability2.gameObject.SetActive(true);
        Weapon.gameObject.SetActive(true);
        ReadyFilter.gameObject.SetActive(true);

        CharacterModel.sprite = data.CharacterModel;
        Ability1.sprite = data.Ability1;
        Ability2.sprite = data.Ability2;
        Weapon.sprite = data.Weapon;
    }
}
