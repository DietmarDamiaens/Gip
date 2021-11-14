using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint1trigger : MonoBehaviour
{
    public GameObject checkpoint0trig;
    public GameObject checkpoint1trig;

    void ontriggerenter()
    {
        checkpoint0trig.SetActive(true);
        checkpoint1trig.SetActive(false);
    }
}
