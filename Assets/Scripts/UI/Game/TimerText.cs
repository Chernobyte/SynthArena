using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    public Text secondText;
    public Text tenthText;
    public Text hundredthText;

    private float currentTime = 0.0f;
    private float currentScale = 1.0f;
    private bool isNegative = false;

	void Start ()
    {
	}
	
	void Update ()
    {
        var splitStr = currentTime.ToString("0.00").Split('.');

        var seconds = int.Parse(splitStr[0]);
        var minus = "";
        if (seconds < 0)
        {
            minus = "-";
            seconds = -seconds;
        }

        var minutes = seconds / 60;
        var remainder = seconds % 60;

        if (minutes == 0)
            secondText.text = minus + remainder;
        else
            secondText.text = minus + minutes + ":" + remainder;

        tenthText.text = "" + splitStr[1][0];
        hundredthText.text = "" + splitStr[1][1];

        gameObject.transform.localScale = new Vector3(currentScale, currentScale);
	}

    public void SetTime(float time)
    {
        currentTime = time;
        if (currentTime < 0)
        {
            isNegative = true;
        }
        else
        {
            isNegative = false;
        }
    }

    public void SetScaleFactor(float scale)
    {
        currentScale = scale;
    }
}
