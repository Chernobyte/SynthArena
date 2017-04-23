
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Overlord : MonoBehaviour {

    public CharacterInfo debugPlayerData;
    public CharacterInfo debugDummyData;

    private List<PlayerSelection> playerSelections;
    private SpawnPoint[] spawnPoints;
    private List<Player> players = new List<Player>();
    private PlayerUI[] playerUIs;
    private List<Player> losers = new List<Player>();
    private AudioSource audioSource;

	void Start ()
    {
        Init();
	}
	
	void Update()
    {
		
	}

    private void Init()
    {
        var mainMenuOverlord = FindObjectOfType<MainMenuOverlord>();
        if (mainMenuOverlord != null)
        {
            Destroy(mainMenuOverlord.gameObject);
        }

        var charSelectOverlord = FindObjectOfType<CharSelectOverlord>();

        if (charSelectOverlord == null) // debug mode
        {
            playerSelections = new List<PlayerSelection>();
            if (debugPlayerData != null)
            {
                playerSelections.Add(new PlayerSelection(1, debugPlayerData));
            }
            if (debugDummyData != null)
            {
                playerSelections.Add(new PlayerSelection(4, debugDummyData));
            }
        }
        else
        {
            playerSelections = charSelectOverlord.RequestPlayerSelections();
            Destroy(charSelectOverlord.gameObject);            
        }

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        spawnPoints = FindObjectsOfType<SpawnPoint>();
        playerUIs = FindObjectsOfType<PlayerUI>();

        foreach (var selection in playerSelections)
        {
            if (selection.characterIcons == null)
                continue;

            var prefab = selection.characterIcons.characterPrefab;

            var spawnPoint = spawnPoints.First(n => n.playerId == selection.playerId);
            var playerUI = playerUIs.First(n => n.playerId == selection.playerId);

            var playerGO = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
            var player = playerGO.GetComponent<Player>();

            players.Add(player);
            player.Init(selection.playerId, this, playerUI, spawnPoint.transform);
            playerUI.Init(selection);
        }

        var inactivePlayerUIs = playerUIs.Where(n => !playerSelections.Exists(x => x.playerId == n.playerId && x.characterIcons.characterPrefab != null));

        foreach (var playerUI in inactivePlayerUIs)
        {
            playerUI.gameObject.SetActive(false);
        }

    }

    public void RegisterLoser(Player player)
    {
        losers.Add(player);

        if (losers.Count >= players.Count-1)
        {
            // TODO: Transition to Victory Screen
            // UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
