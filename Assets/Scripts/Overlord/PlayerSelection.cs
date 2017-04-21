using UnityEngine;

public class PlayerSelection
{
    public readonly int playerId;
    public readonly CharacterInfo characterIcons;

    public PlayerSelection(int playerId, CharacterInfo characterIcons)
    {
        this.playerId = playerId;
        this.characterIcons = characterIcons;
    }
}
