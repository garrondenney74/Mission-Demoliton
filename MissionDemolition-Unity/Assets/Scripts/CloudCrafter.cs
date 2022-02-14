/***
 * Created by Garron Denney
 * Date Created: 2/14/21
 * Last Edited by: N/A
 * Last Date Edited 2/14/21
 * Description Follow Camera code
 * 
 ***/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCrafter : MonoBehaviour
{

    /***Variables***/
    [Header("Set in Inspector")]
    public int numberOfClouds = 40;
    public GameObject cloudPrefab;
    public Vector3 cloudPositionMin = new Vector3(-50, -5, 10);
    public Vector3 cloudPositionMax = new Vector3(150, 100, 10);
    public float cloudScaleMin = 1;
    public float cloudScaleMax = 3;
    public float cloudSpeedMultiplier = 0.5f;

    private GameObject[] cloudInstances;

    private void Awake()
    {
        cloudInstances = new GameObject[numberOfClouds];
        GameObject anchor = GameObject.Find("CloudAnchor");


        GameObject cloud;

        for(int i = 0; i < numberOfClouds; i++)
        {
            cloud = Instantiate<GameObject>(cloudPrefab);


            //position cloud
            Vector3 cPos = Vector3.zero;
            cPos.x = Random.Range(cloudPositionMin.x, cloudPositionMax.x);
            cPos.y = Random.Range(cloudPositionMin.y, cloudPositionMax.y);


            //Scale clouds
            float scaleU = Random.value;
            float scaleVal = Mathf.Lerp(cloudScaleMin, cloudScaleMax, scaleU);

            cPos.y = Mathf.Lerp(cloudPositionMin.y, cPos.y, scaleU);// smaller clouds with smaller scale closer to the ground

        }//end for


    }//end awake


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
