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

    // Update is called once per frame
    void FixedUpdate ()
    {
        ScoreText.text = "Data : " + LargeNumber.ToString((double)Score.Value) + "o";
        DPSText.text = "DPS : " + LargeNumber.ToString((double)DPS.Value) + "o";
    }
    
}
