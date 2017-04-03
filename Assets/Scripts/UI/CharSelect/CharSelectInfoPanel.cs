using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelectInfoPanel : MonoBehaviour {

    public int playerId;

    public Image CharacterModel;
    public Image Ability1;
    public Image Ability2;
    //public Image Weapon;

    public GameObject InactiveOverlay;
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
        InactiveOverlay.SetActive(true);
        CharacterModel.gameObject.SetActive(false);
        Ability1.gameObject.SetActive(false);
        Ability2.gameObject.SetActive(false);
        //Weapon.gameObject.SetActive(false);
        ReadyFilter.gameObject.SetActive(false);
    }

    public void DisplayCharacterInfo(CharacterIconData data)
    {
        InactiveOverlay.SetActive(false);
        CharacterModel.gameObject.SetActive(true);
        Ability1.gameObject.SetActive(true);
        Ability2.gameObject.SetActive(true);
        //Weapon.gameObject.SetActive(true);
        ReadyFilter.gameObject.SetActive(false);

        CharacterModel.sprite = data.characterModel;
        Ability1.sprite = data.ability1;
        Ability2.sprite = data.ability2;
        //Weapon.sprite = data.weapon;
    }

    public void DisplayConfirmInfo(CharacterIconData data)
    {
        InactiveOverlay.SetActive(false);
        CharacterModel.gameObject.SetActive(true);
        Ability1.gameObject.SetActive(true);
        Ability2.gameObject.SetActive(true);
        //Weapon.gameObject.SetActive(true);
        ReadyFilter.gameObject.SetActive(true);

        CharacterModel.sprite = data.characterModel;
        Ability1.sprite = data.ability1;
        Ability2.sprite = data.ability2;
        //Weapon.sprite = data.weapon;
    }
}
