
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

    private bool debug;
    private List<PlayerPlacement> playerPlacements = new List<PlayerPlacement>();
    private bool canAdvance;
    private bool hasAdvanced;

    void Start()
    {
        var previousOverlord = FindObjectOfType<Overlord>();

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

        RenderPlacements();

        StartCoroutine(ScheduleStartText());
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

    private void RenderPlacements()
    {
        foreach (var placement in playerPlacements)
        {
            var prefab = placement.playerSelection.characterIcons.characterPrefab;
            var color = placement.playerSelection.playerColor;

            switch (placement.placement)
            {
                case 1:
                    Instantiate(prefab, firstLocation.position, Quaternion.identity);
                    OneSprite.color = color;
                    winnerText.text = "Player " + placement.playerSelection.playerId + " Wins!";
                    break;
                case 2:
                    Instantiate(prefab, secondLocation.position, Quaternion.identity);
                    TwoSprite.color = color;
                    break;
                case 3:
                    Instantiate(prefab, thirdLocation.position, Quaternion.identity);
                    ThreeSprite.color = color;
                    break;
                case 4:
                    Instantiate(prefab, fourthLocation.position, Quaternion.identity);
                    FourSprite.color = color;
                    break;
            }
        }
    }

    private void HandleInput()
    {
        var startInputReceived = Input.GetButtonDown("Start");

        if (canAdvance && startInputReceived)
        {
            hasAdvanced = true;
            StartCoroutine(GetComponent<SceneFader>().FadeAndLoadScene(SceneFader.FadeDirection.In, "CharSelect", 2.0f));
        }
    }
}
