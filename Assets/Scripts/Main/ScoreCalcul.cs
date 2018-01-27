using ScriptableFramework.Variables;
using UnityEngine;

public class ScoreCalcul : MonoBehaviour {

    private float basicClickValue = 1;

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
	void FixedUpdate ()
    {
        Score.ApplyChange(DPS.Value);
    }

    public void CalculateDPS()
    {
        float scoreToApply = basicClickValue;
        //Add factor calculation for the click
        scoreToApply *= DPC.Value;
        Score.ApplyChange(scoreToApply);
    }

    public void CalculateDPC()
    {
        Score.ApplyChange(basicClickValue);
    }
}
