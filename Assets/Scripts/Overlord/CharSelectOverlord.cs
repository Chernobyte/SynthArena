
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharSelectOverlord : MonoBehaviour {

    public Text startText;

    public AudioClip selectSound;
    public AudioClip confirmSound;
    public AudioClip revertSound;

    private const int maxNumPlayers = 4;
    private CharSelectInfoPanel[] infoPanels;
    private List<PlayerSelection> playerSelections = new List<PlayerSelection>();
    private CharacterSelectOption[] charSelectOptions;
    private bool canStartGame = false;
    private AudioSource audioSource;
    private MainMenuOverlord mainMenuOverlord;
    private SceneFader fader;
    private bool beginLoweringVolume;
    private float beginLoweringVolumeTime;

    void Start()
    {
        fader = GetComponent<SceneFader>();

        InitAudio();
        InitCharSelectOptions();
        InitCharSelectInfoPanels();
        InitCharSelectCursors();
    }

    void Update()
    {
        HandleInput();
        HandleVolume();
    }

    private void InitAudio()
    {
        mainMenuOverlord = FindObjectOfType<MainMenuOverlord>();
        if (mainMenuOverlord == null)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
        else
        {
            audioSource = mainMenuOverlord.GetComponent<AudioSource>();
        }
    }

    void InitCharSelectOptions()
    {
        charSelectOptions = FindObjectsOfType<CharacterSelectOption>().OrderByDescending(n => n.transform.position.y).ToArray();
    }

    void InitCharSelectInfoPanels()
    {
        var infoPanelGOs = GameObject.FindGameObjectsWithTag("CharacterSelectInfoPanel");
        infoPanels = infoPanelGOs.Select(n => n.GetComponent<CharSelectInfoPanel>()).ToArray();
    }

    void InitCharSelectCursors()
    {
        var playerCursorGOs = GameObject.FindGameObjectsWithTag("Cursor");
        var playerCursors = playerCursorGOs.Select(n => n.GetComponent<CharSelectCursor>()).ToArray();

        for (int i=0; i<playerCursors.Length; i++)
        {
            var cursor = playerCursors[i];
            var infoPanel = infoPanels.First(n => n.playerId == cursor.playerId);
            cursor.Init(this, charSelectOptions, infoPanel);
        }
    }

    public void ConfirmSelection(CharSelectCursor cursor, CharacterInfo characterIcons, GameObject characterPrefab, Color playerColor)
    {
        playerSelections.Add(new PlayerSelection(cursor.playerId, playerColor, characterIcons));

        if (playerSelections.Count >= 1)
        //if (playerSelections.Count >= 2)
        {
            canStartGame = true;
        }
    }

    public void CancelSelection(CharSelectCursor cursor)
    {
        var selectionToRemove = playerSelections.First(n => n.playerId == cursor.playerId);
        playerSelections.Remove(selectionToRemove);

        if (playerSelections.Count < 1)
        //if (playerSelections.Count < 2)
        {
            canStartGame = false;
        }
    }

    public List<PlayerSelection> RequestPlayerSelections()
    {
        return playerSelections;
    }

    private void HandleInput()
    {
        startText.gameObject.SetActive(canStartGame);

        var startInputReceived = Input.GetButtonDown("Start");
        var selectInputReceived = Input.GetButtonDown("Select");

        if (canStartGame && startInputReceived)
        {
            DontDestroyOnLoad(gameObject);

            beginLoweringVolume = true;
            beginLoweringVolumeTime = Time.time;

            StartCoroutine(fader.FadeAndLoadScene(SceneFader.FadeDirection.In, "Game", 2.0f));
        }

        if (selectInputReceived)
        {
            if (mainMenuOverlord != null)
                Destroy(mainMenuOverlord.gameObject);

            StartCoroutine(fader.FadeAndLoadScene(SceneFader.FadeDirection.In, "MainMenu", 2.0f));
        }
    }

    private void HandleVolume()
    {
        if (!beginLoweringVolume)
            return;

        var timeLeft = (beginLoweringVolumeTime + 2.0f) - Time.time;
        if (timeLeft < 0)
            timeLeft = 0;

        var lerpFactor = timeLeft / 2.0f;
        var volume = Mathf.Lerp(0, 1, lerpFactor);
        audioSource.volume = volume;
    }

    public void PlaySelectSound()
    {
        audioSource.PlayOneShot(selectSound);
    }

    public void PlayConfirmSound()
    {
        audioSource.PlayOneShot(confirmSound);
    }

    public void PlayRevertSound()
    {
        audioSource.PlayOneShot(revertSound);
    }
}
