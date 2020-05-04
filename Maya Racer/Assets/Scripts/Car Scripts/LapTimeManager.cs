using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int minuteCount;
    public static int secondCount;
    public static float millisecondCount;
    public static string milliDisplay;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliBox;

    void Update()
    {
        millisecondCount += Time.deltaTime * 10;
        milliDisplay = millisecondCount.ToString("F0");
        milliBox.GetComponent<Text>().text = "" + milliDisplay;

        //Change seconds if milliseconds reaches to 10
        if (millisecondCount >= 10)
        {
            millisecondCount = 0;
            secondCount++;
        }

        //Change seconds to have a 0 infront if less than 9 seconds
        if (secondCount <= 9)
        {
            secondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        }
        else
        {
            secondBox.GetComponent<Text>().text = "" + secondCount + ".";
        }

        //Change minutes if seconds reaches to 59
        if (secondCount >= 60)
        {
            secondCount = 0;
            minuteCount++;
        }

        if (minuteCount <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + minuteCount + ":";
        }
        else
        {
            minuteBox.GetComponent<Text>().text = "" + minuteCount + ":";
        }
    }
}
