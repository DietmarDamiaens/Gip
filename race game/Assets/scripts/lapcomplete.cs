using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lapcomplete : MonoBehaviour
{

    public GameObject checkpoint0trig;
    public GameObject checkpoint1trig;

    public GameObject mindisplay;
    public GameObject secondedisplay;
    public GameObject milliedisplay;
    private int minutebest = 0;
    private int secondbest = 0;
    private float millibest = 0;

    public GameObject laptimebox;

    void ontriggerenter()
    {
        if(minutebest < laptimemanager.minutecount)
        {
            laptimemanager.seconddisplay = "" + secondedisplay;

            laptimemanager.millidisplay = "" + milliedisplay;

            laptimemanager.minutedisplay = "" + mindisplay;

        }
        else if(minutebest == laptimemanager.minutecount && secondbest < laptimemanager.secondcount)
        {
            laptimemanager.seconddisplay = "" + secondedisplay;

            laptimemanager.millidisplay = "" + milliedisplay;

            laptimemanager.minutedisplay = "" + mindisplay;
        }
        else if (minutebest == laptimemanager.minutecount && secondbest == laptimemanager.secondcount && millibest < laptimemanager.millicount)
        {
            laptimemanager.seconddisplay = "" + secondedisplay;

            laptimemanager.millidisplay = "" + milliedisplay;

            laptimemanager.minutedisplay = "" + mindisplay;
        }




            laptimemanager.minutecount = 0;
        laptimemanager.secondcount = 0;
        laptimemanager.millicount = 0;

    }

}
