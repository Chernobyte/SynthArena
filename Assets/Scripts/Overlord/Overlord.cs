
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
        var playerUIGOs = GameObject.FindGameObjectsWithTag("PlayerUI");
        var playerUIs = playerUIGOs.Select(n => n.GetComponent<PlayerUI>()).ToArray();

        // init present players
        for (int i=0; i<players.Length; i++)
        {
            var playerId = i + 1;
            var playerUI = playerUIs.Where(n => n.playerId == playerId).First();
            players[i].init(playerId, this, playerUI);
        }

        // hide unused playerUIs
        for (int i=players.Length; i<playerUIGOs.Length; i++)
        {
            var playerId = i + 1;
            var playerUI = playerUIs.Where(n => n.playerId == playerId).First();
            playerUI.gameObject.SetActive(false);
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
