using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerColor
{
    public static readonly Color One = new Color(123.0f / 255, 167.0f / 255, 201.0f / 255);
    public static readonly Color Two = new Color(252.0f / 255, 172.0f / 255, 58.0f / 255);
    public static readonly Color Three = new Color(201.0f / 255, 76.0f / 255, 76.0f / 255);
    public static readonly Color Four = new Color(156.0f / 255, 83.0f / 255, 198.0f / 255);

    public static Color GetColorFromId(int id)
    {
        switch(id)
        {
            case 1: return One;
            case 2: return Two;
            case 3: return Three;
            case 4: return Four;
        }

        return Color.gray;
    }
}
