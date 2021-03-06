<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
/***
 * Created by Garron Denney
 * Date Created: 2/14/21
 * Last Edited by: N/A
 * Last Date Edited 2/16/21
 * Description Creating the line for the projectile
 * 
 ***/








using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLine : MonoBehaviour
{


    static public ProjectileLine S;
    [Header("Set in Inspector")]
    public float minDist = .1f;


    private LineRenderer line;
    private GameObject poi;
    private List<Vector3> points;

    // Start is called before the first frame update



    private void Awake()
    {
        S = this;
        line = GetComponent<LineRenderer>();
        line.enabled = false;
        points = new List<Vector3>();
    }

    public GameObject PoI
    {
        get { return (poi); }
        set
        {
            poi = value;
            if (poi != null)
            {
                line.enabled = false;
                points = new List<Vector3>();
                AddPoints();
<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class ProjectileLine : MonoBehaviour
{
    static public ProjectileLine S;
    public float minDist = .1f;
    [Header("Set in Inspector")]

    public LineRenderer line;
    private GameObject _poi;
    public List<Vector3> points;


    void Awake()
    {
        S = this; // Set the singleton
        // Get a reference to the LineRenderer
        line = GetComponent<LineRenderer>();
        // Disable the LineRenderer until it's needed
        line.enabled = false;
        // Initialize the points List
        points = new List<Vector3>();
    }

    public GameObject poi
    {
        get{
            return(_poi);
        }
        set{
            _poi = value;
            if(_poi != null)
            {
                line.enabled = false;
                points = new List<Vector3>();
                AddPoint();
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
            }
        }
    }

<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
    public void Clear()
    {
        poi = null;
        line.enabled = false;
        points = new List<Vector3>();

    }

    void AddPoints()
    {
        Vector3 pt = poi.transform.position;
        if (points.Count > 0 && (pt - lastPoint).magnitude < minDist)
        {
            return; // if the point is not far enough from the last point
        }

        if (points.Count == 0)
        {
            Vector3 launchPosDiff = pt - Slingshot.LAUNCH_POS;
            points.Add(pt + launchPosDiff);
            points.Add(pt);
            line.positionCount = 2;
            line.SetPosition(0, points[0]);
            line.SetPosition(1, points[1]);
<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    public void Clear(){
        _poi = null;
        line.enabled = false;
        points = new List<Vector3>();
    }
    public void AddPoint()
    {
        Vector3 pt = _poi.transform.position;
        if (points.Count > 0 && (pt - lastPoint).magnitude <minDist)
        {
            return;
        }
        if (points.Count == 0)
        {
            // If this is the launch point...
            Vector3 launchPos = Slingshot.S.launchPoint.transform.position;
            Vector3 launchPosDiff = pt - launchPos;
            // ...it adds an extra bit of line to aid aiming later
            points.Add( pt + launchPosDiff );
            points.Add(pt);
            line.SetVertexCount(2);
            // Sets the first two points
            line.SetPosition(0, points[0] );
            line.SetPosition(1, points[1] );
            // Enables the LineRenderer
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
            line.enabled = true;
        }
        else
        {
<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
            points.Add(pt);
            line.positionCount = points.Count;
            line.SetPosition(points.Count - 1, lastPoint);
            line.enabled = true;
        }
    }

    public Vector3 lastPoint
    {
        get { 
            
            if (points == null) return (Vector3.zero);
            return (points[points.Count - 1]);

<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        // Normal behavior of adding a point
        points.Add( pt );
        line.SetVertexCount( points.Count );
        line.SetPosition( points.Count-1, lastPoint );
        line.enabled = true;
        }

    }
    public Vector3 lastPoint{
        get{
            if(points == null)
            {
                return(Vector3.zero);
            }
            return(points[points.Count-1]);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
        }
        
    }

<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
    private void FixedUpdate()
    {
        if(poi == null)
        {
            if (FollowCam.POI != null)
            {
                if (FollowCam.POI.tag == "Projectile")
                {
                    poi = FollowCam.POI;
<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    void FixedUpdate()
    {
        if (poi == null)
        {
            if(FollowCam.poi != null)
            {
                if(FollowCam.poi.tag == "Projectile")
                {
                    poi = FollowCam.poi;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
                }
                else
                {
                    return;
                }
            }
<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
            else return;
        }
        AddPoints();
        if(FollowCam.POI == null)
<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            else
            {
                return;
            }

        }
        AddPoint();
        if(poi.GetComponent<Rigidbody>().IsSleeping())
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
        {
            poi = null;
        }
    }
<<<<<<< HEAD:Mission-Demolition-Unity/Assets/Scripts/ProjectileLine.cs
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream



=======
    // Start is called before the first frame update
>>>>>>> Stashed changes
=======
    // Start is called before the first frame update
>>>>>>> Stashed changes
=======
    // Start is called before the first frame update
>>>>>>> Stashed changes
=======
    // Start is called before the first frame update
>>>>>>> Stashed changes
=======
    // Start is called before the first frame update
>>>>>>> Stashed changes
=======



>>>>>>> parent of 59a227d (Mission Demolition Stuff):MissionDemolition-Unity/Assets/Scripts/ProjectileLine.cs
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
