
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PostGameOverlord : MonoBehaviour
{
    public CharacterSelectOption debugPlayerFirst;
    public CharacterSelectOption debugPlayerSecond;
    public CharacterSelectOption debugPlayerThird;
    public CharacterSelectOption debugPlayerFourth;

    public Transform firstLocation;
    public Transform secondLocation;
    public Transform thirdLocation;
    public Transform fourthLocation;

    public SpriteRenderer OneSprite;
    public SpriteRenderer TwoSprite;
    public SpriteRenderer ThreeSprite;
    public SpriteRenderer FourSprite;

    public Text winnerText;
    public Text startText;

    public AudioClip firstPlaceSound;
    public AudioClip secondPlaceSound;
    public AudioClip thirdPlaceSound;
    public AudioClip fourthPlaceSound;

    public ParticleSystem appearParticles;

    private bool debug;
    private List<PlayerPlacement> playerPlacements = new List<PlayerPlacement>();
    private bool canAdvance;
    private bool hasAdvanced;
    private AudioSource audioSource;
    private bool beginLoweringVolume;
    private float beginLoweringVolumeTime;
    private float initialMusicVolume;

    void Start()
    {
        var previousOverlord = FindObjectOfType<Overlord>();
        audioSource = GetComponent<AudioSource>();

        initialMusicVolume = audioSource.volume;

        if (previousOverlord == null)
            debug = true;

        if (debug)
        {
            if (debugPlayerFirst != null)
            {
                playerPlacements.Add(new PlayerPlacement(4, new PlayerSelection(1, PlayerColor.One, debugPlayerFirst.toCharacterInfo())));
            }
            if (debugPlayerSecond != null)
            {
                playerPlacements.Add(new PlayerPlacement(3, new PlayerSelection(2, PlayerColor.Two, debugPlayerSecond.toCharacterInfo())));
            }
            if (debugPlayerThird != null)
            {
                playerPlacements.Add(new PlayerPlacement(1, new PlayerSelection(3, PlayerColor.Three, debugPlayerThird.toCharacterInfo())));
            }
            if (debugPlayerFourth != null)
            {
                playerPlacements.Add(new PlayerPlacement(2, new PlayerSelection(4, PlayerColor.Four, debugPlayerFourth.toCharacterInfo())));
            }
        }
        else
        {
            playerPlacements = previousOverlord.RequestPlacements();
            Destroy(previousOverlord.gameObject);
        }

        playerPlacements = playerPlacements.OrderByDescending(n => n.placement).ToList();

        StartCoroutine(RenderPlacements());
    }

    void Update()
    {
        HandleInput();
    }

    private IEnumerator ScheduleStartText()
    {
        yield return new WaitForSeconds(1.0f);

        canAdvance = true;

        yield return new WaitForSeconds(1.0f);

        if (!hasAdvanced)
            startText.enabled = true;
    }

    private IEnumerator RenderPlacements()
    {
        yield return new WaitForSeconds(1.0f);

        foreach (var placement in playerPlacements)
        {
            var prefab = placement.playerSelection.characterIcons.characterPrefab;
            var color = placement.playerSelection.playerColor;
            AudioClip appearSound = null;
            Vector3 position = Vector3.zero;
            SpriteRenderer numberSprite = null;

            switch (placement.placement)
            {
                case 1:
                    position = firstLocation.position;
                    numberSprite = OneSprite;
                    winnerText.text = "Player " + placement.playerSelection.playerId + " Wins!";
                    appearSound = firstPlaceSound;
                    break;
                case 2:
                    position = secondLocation.position;
                    numberSprite = TwoSprite;
                    appearSound = secondPlaceSound;
                    break;
                case 3:
                    position = thirdLocation.position;
                    numberSprite = ThreeSprite;
                    appearSound = thirdPlaceSound;
                    break;
                case 4:
                    position = fourthLocation.position;
                    numberSprite = FourSprite;
                    appearSound = fourthPlaceSound;
                    break;
            }

            Instantiate(prefab, position, Quaternion.identity);

            if (appearSound != null)
                audioSource.PlayOneShot(appearSound);

            if (numberSprite != null)
                numberSprite.color = color;

            appearParticles.transform.position = position;
            appearParticles.Play();

            yield return new WaitForSeconds(1.0f);
        }

        winnerText.gameObject.SetActive(true);
        winnerText.GetComponent<Animator>().SetTrigger("Appear");

        StartCoroutine(ScheduleStartText());

        //yield return new WaitForSeconds(0.5f);

        audioSource.Play();
    }

    private void HandleInput()
    {
        var startInputReceived = Input.GetButtonDown("Start");

        if (canAdvance && startInputReceived)
        {
            hasAdvanced = true;
            beginLoweringVolume = true;
            beginLoweringVolumeTime = Time.time;
            StartCoroutine(GetComponent<SceneFader>().FadeAndLoadScene(SceneFader.FadeDirection.In, "CharSelect", 2.0f));
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
        var volume = Mathf.Lerp(0, initialMusicVolume, lerpFactor);
        audioSource.volume = volume;
    }
}
