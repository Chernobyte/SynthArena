
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PostGameOverlord : MonoBehaviour
{
    public CharacterInfo debugPlayerFirst;
    public CharacterInfo debugPlayerSecond;
    public CharacterInfo debugPlayerThird;
    public CharacterInfo debugPlayerFourth;

    public Transform firstLocation;
    public Transform secondLocation;
    public Transform thirdLocation;
    public Transform fourthLocation;

    private bool debug;
    private List<PlayerPlacement> playerPlacements = new List<PlayerPlacement>();

    void Start()
    {
        var previousOverlord = FindObjectOfType<Overlord>();

        if (previousOverlord == null)
            debug = true;

        if (debug)
        {
            if (debugPlayerFirst != null)
            {
                playerPlacements.Add(new PlayerPlacement(1, new PlayerSelection(1, debugPlayerFirst)));
            }
            if (debugPlayerSecond != null)
            {
                playerPlacements.Add(new PlayerPlacement(2, new PlayerSelection(2, debugPlayerSecond)));
            }
            if (debugPlayerThird != null)
            {
                playerPlacements.Add(new PlayerPlacement(3, new PlayerSelection(3, debugPlayerThird)));
            }
            if (debugPlayerFourth != null)
            {
                playerPlacements.Add(new PlayerPlacement(4, new PlayerSelection(4, debugPlayerFourth)));
            }
        }
        else
        {
            playerPlacements = previousOverlord.RequestPlacements();
            Destroy(previousOverlord.gameObject);
        }

        RenderPlacements();
    }

    void Update()
    {
    }

    private void RenderPlacements()
    {
        foreach (var placement in playerPlacements)
        {
            var prefab = placement.playerSelection.characterIcons.characterPrefab;

            switch (placement.placement)
            {
                case 1: Instantiate(prefab, firstLocation.position, Quaternion.identity); break;
                case 2: Instantiate(prefab, secondLocation.position, Quaternion.identity); break;
                case 3: Instantiate(prefab, thirdLocation.position, Quaternion.identity); break;
                case 4: Instantiate(prefab, fourthLocation.position, Quaternion.identity); break;
            }
        }
    } 
}
