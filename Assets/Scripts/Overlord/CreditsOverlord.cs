
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsOverlord : MonoBehaviour
{
    public AudioClip selectSound;
    public AudioClip confirmSound;

    private AudioSource audioSource;
    private MainMenuOverlord mainMenuOverlord;

    void Start()
    {
        InitAudio();
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

    public void LoadMenu()
    {
        if (mainMenuOverlord != null)
            Destroy(mainMenuOverlord.gameObject);

        audioSource.PlayOneShot(confirmSound);
        SceneManager.LoadScene("MainMenu");
    }
}
