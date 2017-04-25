using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlacement
{
    public int placement;
    public PlayerSelection playerSelection;

    public PlayerPlacement(int placement, PlayerSelection playerSelection)
    {
        this.placement = placement;
        this.playerSelection = playerSelection;
    }
}
