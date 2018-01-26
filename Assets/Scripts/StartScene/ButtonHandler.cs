using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

    public Text NameOfGame;

    /// <summary>
    /// Method to Start the game
    /// </summary>
    public void StartApp()
    {
        SceneManager.LoadScene("Main");
    }

    /// <summary>
    /// Method to Stop the game
    /// </summary>
	public void QuitApp()
    {
        Application.Quit();
    }

    /// <summary>
    /// Method to load a previous game
    /// </summary>
    public void LoadGame()
    {
        NameOfGame.text = "WUUUUUUUUUUUUUUUUUUUUUUUUUT";
        //TODO !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }
}
