using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timescale : MonoBehaviour
{
    private float modifiedscale;

    // Start is called before the first frame update
    void Start()
    {
        modifiedscale = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = modifiedscale;
    }
}
