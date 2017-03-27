
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharSelectOverlord : MonoBehaviour {
    
    private const int maxNumPlayers = 4;
    private CharSelectCursor[] cursors;
    private CharSelectInfoPanel[] infoPanels;
    private List<CharSelectCursor> readyCursors = new List<CharSelectCursor>();
    private CharacterIconData[] charSelectOptions;

    void Start()
    {
        InitCharSelectOptions();
        InitCharSelectInfoPanels();
        InitCharSelectCursors();
    }

    void Update()
    {

    }

    void InitCharSelectOptions()
    {
        var charSelectOptionGOs = GameObject.FindGameObjectsWithTag("CharacterSelectOption");
        charSelectOptions = charSelectOptionGOs.Select(n => n.GetComponent<CharacterIconData>()).OrderByDescending(n => n.transform.position.y).ToArray();
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

    public void ConfirmCursor(CharSelectCursor cursor)
    {
        readyCursors.Add(cursor);
    }

    public void CancelCursor(CharSelectCursor cursor)
    {
        readyCursors.Remove(cursor);
    }
}
