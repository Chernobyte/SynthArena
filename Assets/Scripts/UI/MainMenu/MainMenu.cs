using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public AudioClip tapeDeck;

	// Use this for initialization
	void Start () {
        StartCoroutine(OpeningSequence());

    }

    IEnumerator OpeningSequence()
    {
        AudioSource.PlayClipAtPoint(tapeDeck, Vector3.one);

        yield return new WaitForSecondsRealtime(2);
        var fader = GetComponent<SceneFader>();
        fader.enabled = true;

        var audio = GetComponent<AudioSource>();
        audio.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadGame()
    {
        //SceneManager.LoadScene("CharSelect");
		StartCoroutine(GameObject.FindObjectOfType<SceneFader>().FadeAndLoadScene(SceneFader.FadeDirection.In, "CharSelect", 2));
    }

    public void QuitGame()
    {
        // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
