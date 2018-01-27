using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {
    
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
        Debug.Log("Not working in Play Mode");
        Application.Quit();
    }

    /// <summary>
    /// Method to load a previous game
    /// </summary>
    public void LoadGame()
    {
        Debug.Log("Nothing in the credits yet");
        //TODO !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }

}
