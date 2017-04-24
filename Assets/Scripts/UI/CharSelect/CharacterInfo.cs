using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo {

    public string characterName;
    public string weaponName;
    public string ability1Name;
    public string ability2Name;

    public Sprite characterModel;
    public Sprite characterIcon;
    public Sprite ability1Icon;
    public Sprite ability2Icon;

    public GameObject characterPrefab;

	public CharacterInfo(string characterName, string weaponName, string ability1Name, string ability2Name, Sprite characterModel, Sprite characterIcon, Sprite ability1Icon, Sprite ability2Icon, GameObject characterPrefab)
    {
        this.characterName = characterName;
        this.weaponName = weaponName;
        this.ability1Name = ability1Name;
        this.ability2Name = ability2Name;
        this.characterModel = characterModel;
        this.characterIcon = characterIcon;
        this.ability1Icon = ability1Icon;
        this.ability2Icon = ability2Icon;
        this.characterPrefab = characterPrefab;
    }
}
