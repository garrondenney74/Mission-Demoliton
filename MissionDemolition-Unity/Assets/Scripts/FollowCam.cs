/***
 * Created by Garron Denney
 * Date Created: 2/9/21
 * Last Edited by: N/A
 * Last Date Edited 2/9/21
 * Description Follow Camera code
 * 
 ***/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    /***Variables***/
    static public GameObject POI; //static point of interest
    public float camZ; //the desired Z pos of the camera


    private void Awake()
    {
        camZ = this.transform.position.z;
    }//end Awake()
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        if (POI == null) return;//if no point of interest exit update

        Vector3 destination = POI.transform.position;
        destination.z = camZ;
        transform.position = destination;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
