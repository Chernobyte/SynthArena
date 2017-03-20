
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
        var healthDisplayGOs = GameObject.FindGameObjectsWithTag("HealthBar");
        var healthBars = healthDisplayGOs.Select(n => n.GetComponent<HealthBar>()).ToArray();

        for (int i=0; i<players.Length; i++)
        {
            var playerId = i + 1;
            var healthBar = healthBars.Where(n => n.playerId == playerId).First();
            players[i].init(playerId, this, healthBar);
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
