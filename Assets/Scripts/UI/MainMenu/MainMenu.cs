using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public AudioClip tapeDeck;
    public AudioClip selectSound;
    public AudioClip confirmSound;

    private AudioSource audioSource;
    private Button[] buttons;
    private bool inSequence = true;

	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        buttons = FindObjectsOfType<Button>();
        StartCoroutine(OpeningSequence());

        DontDestroyOnLoad(audioSource);
    }

    IEnumerator OpeningSequence()
    {
        EnterSequence();
        audioSource.PlayOneShot(tapeDeck);

        yield return new WaitForSeconds(2);

        ExitSequence();

        var fader = GetComponent<SceneFader>();
        fader.enabled = true;
        
        audioSource.Play();
    }

    public void LoadGame()
    {
        PlayConfirmSound();
        SceneManager.LoadScene("CharSelect");

		//StartCoroutine(GameObject.FindObjectOfType<SceneFader>().FadeAndLoadScene(SceneFader.FadeDirection.In, "CharSelect", 1));
        //EnterSequence();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlaySelectSound()
    {
        if (inSequence)
            return;

        audioSource.PlayOneShot(selectSound);
    }

    public void PlayConfirmSound()
    {
        if (inSequence)
            return;

        audioSource.PlayOneShot(confirmSound);
    }

    private void EnterSequence()
    {
        inSequence = true;
        DisableButtons();
    }

    private void ExitSequence()
    {
        inSequence = false;
        EnableButtons();
    }

    private void EnableButtons()
    {
        foreach (var button in buttons)
        {
            button.enabled = true;
        }
    }

    private void DisableButtons()
    {
        foreach (var button in buttons)
        {
            button.enabled = false;
        }
    }
}
