using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lapcomplete : MonoBehaviour
{

    public GameObject checkpoint0trig;
    public GameObject checkpoint1trig;

    public GameObject mindisplay;
    public GameObject seconddisplay;
    public GameObject milliedisplay;

    public GameObject laptimebox;

    void ontriggerenter()
    {
        if(laptimemanager.secondcount <= 9)
        {
            seconddisplay.GetComponent<Text>().text = "0" + laptimemanager.secondcount + ".";
        }
        else
        {
            seconddisplay.GetComponent<Text>().text = "" + laptimemanager.secondcount + ".";
        }

        laptimemanager.millidisplay.GetComponent<Text>().text = "" + milliedisplay;
        

        if (laptimemanager.minutecount <= 9)
        {
            laptimemanager.minutebox.GetComponent<Text>().text = "0" + minutedisplay + ":";
        }
        else
        {
            laptimemanager.minutebox.GetComponent<Text>().text = "" + minutedisplay + ":";
        }

        laptimemanager.minutecount = 0;
        laptimemanager.secondcount = 0;
        laptimemanager.millicount = 0;


    }

}
