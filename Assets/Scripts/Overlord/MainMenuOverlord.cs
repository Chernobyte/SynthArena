using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuOverlord : MonoBehaviour {

    public AudioClip startupSound;
    public AudioClip tapeDeck;
    public AudioClip selectSound;
    public AudioClip confirmSound;

    public Animator logoAnimator;

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

    private IEnumerator OpeningSequence()
    {
        EnterSequence();

        audioSource.PlayOneShot(tapeDeck);

        yield return new WaitForSeconds(6.0f);

        audioSource.PlayOneShot(startupSound);

        yield return new WaitForSeconds(5.0f);

        ExitSequence();

        var fader = GetComponent<SceneFader>();
        StartCoroutine(fader.Fade(SceneFader.FadeDirection.Out, 2.0f));
        
        audioSource.Play();
    }

    public void LoadGame()
    {
        PlayConfirmSound();
        SceneManager.LoadScene("CharSelect");
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
