using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWihileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello world");

        } while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
