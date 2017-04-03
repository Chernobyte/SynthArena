using UnityEngine;

public class PlayerSelection
{
    public readonly int playerId;
    public readonly CharacterIconData characterIcons;

    public PlayerSelection(int playerId, CharacterIconData characterIcons)
    {
        this.playerId = playerId;
        this.characterIcons = characterIcons;
    }
}
