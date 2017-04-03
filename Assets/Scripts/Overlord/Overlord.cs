
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Overlord : MonoBehaviour {

    public CharacterIconData debugPlayerData;
    public CharacterIconData debugDummyData;

    private List<PlayerSelection> playerSelections;
    private SpawnPoint[] spawnPoints;
    private Player[] players;
    private PlayerUI[] playerUIs;
    private bool playersCached = false;

	void Start ()
    {
        Init();
	}
	
	void Update()
    {
		
	}

    private void Init()
    {
        var charSelectOverlord = FindObjectOfType<CharSelectOverlord>();

        if (charSelectOverlord == null) // debug mode
        {

            playerSelections = new List<PlayerSelection>()
            {
                new PlayerSelection(1, debugPlayerData),
                new PlayerSelection(4, debugDummyData)
            };
        }
        else
        {
            playerSelections = charSelectOverlord.ReqeustPlayerSelections();
            Destroy(charSelectOverlord);            
        }

        spawnPoints = FindObjectsOfType<SpawnPoint>();
        playerUIs = FindObjectsOfType<PlayerUI>();

        foreach (var selection in playerSelections)
        {
            var prefab = selection.characterIcons.characterPrefab;

            if (prefab  == null)
                continue;

            var spawnPoint = spawnPoints.First(n => n.playerId == selection.playerId);
            var playerUI = playerUIs.First(n => n.playerId == selection.playerId);

            var playerGO = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
            var player = playerGO.GetComponent<Player>();
            player.Init(selection.playerId, this, playerUI);
            playerUI.Init(selection);
        }

        var inactivePlayerUIs = playerUIs.Where(n => !playerSelections.Exists(x => x.playerId == n.playerId && x.characterIcons.characterPrefab != null));

        foreach (var playerUI in inactivePlayerUIs)
        {
            playerUI.gameObject.SetActive(false);
        }
    }
}
