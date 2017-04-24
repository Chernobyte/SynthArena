using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectOption : MonoBehaviour
{
    public string characterName;
    public string weaponName;
    public string ability1Name;
    public string ability2Name;

    public Sprite characterModel;
    public Sprite characterIcon;
    public Sprite ability1Icon;
    public Sprite ability2Icon;

    public GameObject characterPrefab;

    void Start()
    {

    }

    void Update()
    {

    }

    public CharacterInfo toCharacterInfo()
    {
        return new CharacterInfo(characterName, weaponName, ability1Name, ability2Name, characterModel, characterIcon, ability1Icon, ability2Icon, characterPrefab);
    }
}
