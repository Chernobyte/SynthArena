using UnityEngine;

public class PlayerSelection
{
    public readonly int playerId;
    public readonly GameObject characterPrefab;

    public PlayerSelection(int playerId, GameObject characterPrefab)
    {
        this.playerId = playerId;
        this.characterPrefab = characterPrefab;
    }
}
