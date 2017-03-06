
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Overlord : MonoBehaviour {

    Player[] players;
    bool playersCached = false;

	void Start () {
        cachePlayers();
        initPlayers();
	}
	
	void Update () {
		
	}

    void cachePlayers()
    {
        if (playersCached) return;

        GameObject[] playerGOs = GameObject.FindGameObjectsWithTag("Player");
        players = playerGOs.Select(n => n.GetComponent<Player>()).ToArray();
        playersCached = true;
    }

    void initPlayers()
    {
        for (int i=0; i<players.Length; i++)
        {
            players[i].init(i+1, this);
        }
    }

    public Player[] requestPlayers()
    {
        if (playersCached) return players;
        else
        {
            cachePlayers();
            return players;
        }
    }
}
