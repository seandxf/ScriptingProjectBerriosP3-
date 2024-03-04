using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DualAxisExample : MonoBehaviour
{
  //ublic Text horizontalValueDisplayText;
   //ublic Text verticalValueDisplayText;
    public float hRange;
    public float vRange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;


    }
}
