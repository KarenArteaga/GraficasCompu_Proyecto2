using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverLuz();
    }
    void MoverLuz()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0.0f, 0.2f, 0.0f);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0.0f, -0.2f, 0.0f);
        }
    }
}
