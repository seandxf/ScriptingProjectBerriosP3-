using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SingleCharacterScript;

public class SingleCharacterScript : MonoBehaviour
{
    // Start is called before the first frame update
   public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;


        public Stuff(int bul, int gre, int roc) {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }
    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    // Update is called once per frame
    void Update()
    {

    }
}
   


  
    
    

