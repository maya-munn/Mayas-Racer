using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Resets the lap timer when the lap trigger is hit.
/// Author: Maya Ashizumi-Munn
/// </summary>
public class LapComplete : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject halfLapTrigger;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject millisecondDisplay;

    public GameObject lapTimeBox;

    //***************************************//
    

    public void OnTriggerEnter(Collider other)
    {
        //Ensures that if the second count display will always be 2 digits
        if (LapTimeManager.secondCount <= 9)
        {
            secondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
        }
        else
        {
            secondDisplay.GetComponent<Text>().text = "" + LapTimeManager.secondCount + ".";
        }

        //Ensures that if the minute count display will always be 2 digits
        if (LapTimeManager.minuteCount <= 9)
        {
            minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ".";
        }
        else
        {
            minuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ".";
        }

        //Reset the milli count
        millisecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.millisecondCount;

        //Reset all time displays
        LapTimeManager.minuteCount = 0;
        LapTimeManager.secondCount = 0;
        LapTimeManager.minuteCount = 0;

        //Reset triggers
        halfLapTrigger.SetActive(true);
        lapCompleteTrigger.SetActive(false);
    }
}
