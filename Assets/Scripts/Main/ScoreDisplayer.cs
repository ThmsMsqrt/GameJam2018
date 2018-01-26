using ScriptableFramework.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayer : MonoBehaviour {

    [Header("Total Score Object")]
    public Text ScoreText;
    public FloatReference Score;

    [Header("Data Per Second Object")]
    public Text DPSText;
    public FloatReference DPS;

    private string DataScale = "o";

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ScoreText.text = "Data : " + (int)Score.Value + DataScale;
        DPSText.text = "Data per second : " + DPS.Value + DataScale;
    }
}
