using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class AxisRawExample : MonoBehaviour
{
    public float range;
    public Text textOutput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        
    }
}
