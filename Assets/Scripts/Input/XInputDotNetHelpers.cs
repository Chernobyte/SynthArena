
using UnityEngine;
using XInputDotNetPure;

public class XInputDotNetHelpers {

    public static PlayerIndex MapPlayerIdToPlayerIndex(int playerId)
    {
        switch (playerId)
        {
            case 1: return PlayerIndex.One;
            case 2: return PlayerIndex.Two;
            case 3: return PlayerIndex.Three;
            case 4: return PlayerIndex.Four;
            default:
                Debug.Log("PlayerId out of bounds (" + playerId + "), setting PlayerIndex to One");
                return PlayerIndex.One;
        }
    }

    public static void MapButtonStateToReceivedStopped(ButtonState current, ButtonState previous, out bool received, out bool stopped)
    {
        if (current != previous)
        {
            if (current == ButtonState.Pressed)
            {
                received = true;
                stopped = false;
            }
            else
            {
                stopped = true;
                received = false;
            }
        }
        else
        {
            received = false;
            stopped = false;
        }
    }
}
