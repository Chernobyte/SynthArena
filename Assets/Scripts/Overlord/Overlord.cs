
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Overlord : MonoBehaviour {

    public CharacterInfo debugPlayerData;
    public CharacterInfo debugDummyData;
    public TimerText startTimerText;
    public float startTimerDuration = 5.0f;
    public Transform timerFinalPosition;
    public float timerFinalScale;
    public AudioClip countdownSound1;
    public AudioClip countdownSound2;
    public AudioSource battleMusicPlayer;

    private List<PlayerSelection> playerSelections;
    private SpawnPoint[] spawnPoints;
    private List<Player> players = new List<Player>();
    private PlayerUI[] playerUIs;
    private List<Player> losers = new List<Player>();
    private AudioSource audioSource;
    private SceneFader fader;
    private float sceneLoadTime;
    private bool startSequenceComplete = false;
    private Vector3 timerInitialPosition;
    private int timerInitialFontSize;
    private int previousSecond;
    private bool initialized = false;

	void Start ()
    {
        Init();
	}
	
	void Update()
    {
        if (!initialized)
            return;

        if (!startSequenceComplete)
        {
            var timeUntil = startTimerDuration - (Time.time - sceneLoadTime);
            var second = (int)timeUntil;
            if (previousSecond != second)
            {
                audioSource.PlayOneShot(countdownSound1);
                previousSecond = second;
            }

            if (timeUntil <= 0)
            {
                startSequenceComplete = true;

                startTimerText.SetTime(0);

                players.ForEach(n => n.SetAcceptInput(true));

                audioSource.PlayOneShot(countdownSound2);

                battleMusicPlayer.Play();
            }
            else
            {
                startTimerText.SetTime(-timeUntil);
                var lerpFactor = timeUntil / startTimerDuration;
                
                var lerpPos = Vector3.Lerp(timerFinalPosition.position, timerInitialPosition, lerpFactor);

                var scale = Mathf.Lerp(timerFinalScale, 1, lerpFactor);

                startTimerText.transform.position = lerpPos;
                startTimerText.SetScaleFactor(scale);
            }
        }
        else
        {
            var gameTime = Time.time - (sceneLoadTime + startTimerDuration);
            startTimerText.SetTime(gameTime);
        }

        
	}

    private void Init()
    {
        sceneLoadTime = Time.time;

        bool debug = false;

        var charSelectOverlord = FindObjectOfType<CharSelectOverlord>();

        if (charSelectOverlord == null)
            debug = true;

        if (debug)
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
            var mainMenuOverlord = FindObjectOfType<MainMenuOverlord>();
            if (mainMenuOverlord != null)
            {
                Destroy(mainMenuOverlord.gameObject);
            }

            playerSelections = charSelectOverlord.RequestPlayerSelections();
            Destroy(charSelectOverlord.gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        spawnPoints = FindObjectsOfType<SpawnPoint>();
        playerUIs = FindObjectsOfType<PlayerUI>();
        timerInitialPosition = new Vector3(startTimerText.transform.position.x, startTimerText.transform.position.y);

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

        fader = GetComponent<SceneFader>();

        StartCoroutine(fader.Fade(SceneFader.FadeDirection.Out, startTimerDuration));

        initialized = true;
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
