using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laptimemanager : MonoBehaviour
{
    public static int minutecount;
    public static int secondcount;
    public static float millicount;
    public static string minutedisplay;
    public static string seconddisplay;
    public static string millidisplay;
    public GameObject minutebox;
    public GameObject secondbox;
    public GameObject millibox;

    void Update()
    {
        millicount += Time.deltaTime * 10;
        millidisplay = millicount.ToString("F0");
        millibox.GetComponent<Text>().text = "" + millidisplay;

        if (millicount >= 10)
        {
            millicount = 0;
            secondcount = secondcount + 1;
        }

        if(secondcount<= 9)
        {
            secondbox.GetComponent<Text>().text = "0" + secondcount + ".";
        }
        else
        {
            secondbox.GetComponent<Text>().text = "" + secondcount + ".";
        }
        seconddisplay = secondbox.GetComponent<Text>().text;

        if (secondcount >= 60)
        {
            secondcount = 0;
            minutecount = minutecount + 1;
        }

        if (minutecount <= 9)
        {
            minutebox.GetComponent<Text>().text = "0" + minutecount + ":";
        }
        else
        {
            minutebox.GetComponent<Text>().text = "" + minutecount + ":";
        }

        minutedisplay = minutebox.GetComponent<Text>().text;
    }
}
