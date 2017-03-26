
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharSelectOverlord : MonoBehaviour {
    
    private const int maxNumPlayers = 4;
    private Cursor[] cursors;
    private List<Cursor> readyCursors;
    private GameObject[] charSelectOptions;

    void Start()
    {
        InitReadyCursors();
        InitCharSelectOptions();
        InitCursors();
    }

    void Update()
    {

    }

    void InitReadyCursors()
    {
        readyCursors = new List<Cursor>();
    }

    void InitCharSelectOptions()
    {
        charSelectOptions = GameObject.FindGameObjectsWithTag("CharacterSelectOption").OrderByDescending(n => n.transform.position.y).ToArray();
    }

    void InitCursors()
    {
        var playerCursorGOs = GameObject.FindGameObjectsWithTag("Cursor");
        var playerCursors = playerCursorGOs.Select(n => n.GetComponent<Cursor>()).ToArray();

        for (int i=0; i<playerCursors.Length; i++)
        {
            playerCursors[i].Init(this, charSelectOptions);
        }
    }

    public void ConfirmCursor(Cursor cursor)
    {
        readyCursors.Add(cursor);
    }

    public void CancelCursor(Cursor cursor)
    {
        readyCursors.Remove(cursor);
    }
}
