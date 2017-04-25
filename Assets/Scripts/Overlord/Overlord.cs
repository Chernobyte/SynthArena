
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Overlord : MonoBehaviour {

    public CharacterSelectOption debugPlayerData;
    public CharacterSelectOption debugDummyData;
    public TimerText startTimerText;
    public float startTimerDuration = 5.0f;
    public Transform timerFinalPosition;
    public float timerFinalScale;
    public AudioClip countdownSound1;
    public AudioClip countdownSound2;
    public AudioSource battleMusicPlayer;
    public GameObject gameOverText;
    public Image endGameFadeMask;

    private List<PlayerSelection> playerSelections;
    private SpawnPoint[] spawnPoints;
    private List<Player> players = new List<Player>();
    private PlayerUI[] playerUIs;
    private List<PlayerPlacement> playerPlacements = new List<PlayerPlacement>();
    private AudioSource audioSource;
    private SceneFader fader;
    private float sceneLoadTime;
    private bool startSequenceComplete = false;
    private Vector3 timerInitialPosition;
    private int timerInitialFontSize;
    private int previousSecond;
    private bool initialized = false;
    private bool gameIsOver = false;
    private float gameOverTime;
    private float postGameTransitionTime = 3.0f;
    private float battleMusicInitialVolume;

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
                players.ForEach(n => n.SetCalculateGravity(true));

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
        else if (!gameIsOver)
        {
            var gameTime = Time.time - (sceneLoadTime + startTimerDuration);
            startTimerText.SetTime(gameTime);
        }
        else if (gameIsOver)
        {
            var timeLeft = (gameOverTime + postGameTransitionTime) - Time.time;
            if (timeLeft < 0)
                timeLeft = 0;

            var lerpFactor = timeLeft / postGameTransitionTime;
            var volume = Mathf.Lerp(0, battleMusicInitialVolume, lerpFactor);
            battleMusicPlayer.volume = volume;
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
                playerSelections.Add(new PlayerSelection(1, PlayerColor.One, debugPlayerData.toCharacterInfo()));
            }
            if (debugDummyData != null)
            {
                playerSelections.Add(new PlayerSelection(4, PlayerColor.Four, debugDummyData.toCharacterInfo()));
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
            {
                continue;
            }
                

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

        battleMusicInitialVolume = battleMusicPlayer.volume;

        fader = GetComponent<SceneFader>();

        StartCoroutine(fader.Fade(SceneFader.FadeDirection.Out, startTimerDuration));

        initialized = true;
    }

    public void RegisterLoser(Player player)
    {
        var placement = players.Count - playerPlacements.Count;
        var selection = playerSelections.FirstOrDefault(n => n.playerId == player.PlayerId());

        if (selection == null)
        {
            Debug.Log("Error: Unknown no selection with id = " + player.PlayerId());
            return;
        }

        playerPlacements.Add(new PlayerPlacement(placement, selection));

        if (playerPlacements.Count == players.Count-1)
        {
            var winner = playerSelections
                .First(n => !playerPlacements.Exists(x => x.playerSelection.playerId == n.playerId));

            playerPlacements.Add(new PlayerPlacement(1, winner));

            GameOver();
        }

        else if (playerPlacements.Count > players.Count-1) // when the only player dies
        {
            GameOver();
        }
    }

    public List<PlayerPlacement> RequestPlacements()
    {
        return playerPlacements.ToList();
    }

    private void GameOver()
    {
        gameIsOver = true;
        gameOverTime = Time.time;

        players.ForEach(n => n.SetAcceptInput(false));

        fader.fadeOutUIImage = endGameFadeMask;

        gameOverText.SetActive(true);
        gameOverText.GetComponent<Animator>().SetTrigger("Animate");

        DontDestroyOnLoad(gameObject);

        StartCoroutine(fader.FadeAndLoadScene(SceneFader.FadeDirection.In, "PostGame", postGameTransitionTime));
    }
}
