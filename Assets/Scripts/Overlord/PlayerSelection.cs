using UnityEngine;

public class PlayerSelection
{
    public readonly int playerId;
    public readonly Color playerColor;
    public readonly CharacterInfo characterIcons;

    public PlayerSelection(int playerId, Color playerColor, CharacterInfo characterIcons)
    {
        this.playerId = playerId;
        this.playerColor = playerColor;
        this.characterIcons = characterIcons;
    }
}
