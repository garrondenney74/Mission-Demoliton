using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    static public bool goalMet = false;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Projectile")
        {
            Goal.goalMet = true;
        }
        Color c = renderer.material.color;
        c.a = 1;
        renderer.material.color = c;
    }
=======
=======
>>>>>>> Stashed changes
    // A static field accessible by code anywhere
    static public bool goalMet = false;
    void OnTriggerEnter( Collider other ) 
    {
        // When the trigger is hit by something
        // Check to see if it's a Projectile
        if ( other.gameObject.tag == "Projectile" ) 
        {
            // If so, set goalMet to true
            Goal.goalMet = true;
            // Also set the alpha of the color to higher opacity
            Color c = GetComponent<Renderer>().material.color;
            c.a = 1;
            GetComponent<Renderer>().material.color = c;
        }
}
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
