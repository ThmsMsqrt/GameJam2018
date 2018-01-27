using ScriptableFramework.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboard : MonoBehaviour {

    public GameEvent OnUpClicked;
    public GameEvent OnDownClicked;
    public GameEvent On1Clicked;
    public GameEvent On2Clicked;
    public GameEvent On3Clicked;
    public GameEvent OnEnterClicked;
    public GameEvent OnEscClicked;

    bool UpIsClicked;

    // Update is called once per frame
    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            OnUpClicked.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            OnDownClicked.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            On1Clicked.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            On2Clicked.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            On3Clicked.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown("enter"))
        {
            OnEnterClicked.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnEscClicked.Raise();
        }

    }
}
