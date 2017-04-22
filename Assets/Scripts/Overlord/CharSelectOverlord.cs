
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
    private CharacterInfo[] charSelectOptions;
    private bool canStartGame = false;
    private AudioSource audioSource;
    private MainMenuOverlord mainMenuOverlord;

    void Start()
    {
        InitAudio();
        InitCharSelectOptions();
        InitCharSelectInfoPanels();
        InitCharSelectCursors();
    }

    void Update()
    {
        HandleInput();
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
        charSelectOptions = FindObjectsOfType<CharacterInfo>().OrderByDescending(n => n.transform.position.y).ToArray();
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

    public void ConfirmSelection(CharSelectCursor cursor, CharacterInfo characterIcons, GameObject characterPrefab)
    {
        playerSelections.Add(new PlayerSelection(cursor.playerId, characterIcons));

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
        return playerSelections.ToList();
    }

    private void HandleInput()
    {
        var startInputReceived = Input.GetButtonDown("Start");
        startText.gameObject.SetActive(canStartGame);

        if (canStartGame && startInputReceived)
        {
            DontDestroyOnLoad(gameObject);

            StartCoroutine(GameObject.FindObjectOfType<SceneFader>().FadeAndLoadScene(SceneFader.FadeDirection.In, "Game"));
        }
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
