using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint0trigger : MonoBehaviour
{
    public GameObject checkpoint0trig;
    public GameObject checkpoint1trig;

    void ontriggerenter()
    {
        checkpoint1trig.SetActive(true);
        checkpoint0trig.SetActive(false);
    }
}
