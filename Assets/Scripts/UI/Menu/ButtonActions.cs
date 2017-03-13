/*
 * Created: 2-15-17
 * Contributors: Evan Preslar
 * Houses various Functions for use in the main menu
 */

using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour {

	public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
