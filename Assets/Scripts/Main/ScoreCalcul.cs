using ScriptableFramework.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalcul : MonoBehaviour {

    float basicClickValue = 1;
    float timing = 0f;

    public FloatVariable Score;
    public FloatVariable DPS;
    public FloatVariable DPC;

    // Use this for initialization
    void Start ()
    {
        //Init score value
        Score.SetValue(0f);
        DPS.SetValue(0.01f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Score.ApplyChange(DPS.Value);
    }

    public void CalculateClickScore()
    {
        float scoreToApply = basicClickValue;

        //Add factor calculation for the click
        scoreToApply *= DPC.Value;
        Score.ApplyChange(scoreToApply);
    }
}
