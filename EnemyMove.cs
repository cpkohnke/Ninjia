using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float startWaitTime;
    private float waitTime;
    //Array of waypoints to walk from one to the next one
    public Transform [] waypoints;
    //Walk speed that can be set in Inspector
    public float moveSpeed;
    //Index of current waypoint from which Enemy walks
    //to the next one 
    private int waypointIndex;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        waypointIndex = Random.Range(0, waypoints.Length);
    }
 // Update is called once per frame
    void Update()
    {
        //Move Enemy
        Move();
    }

   
    void Move()
    {
        //Move Enemy from current waypoint to the next one
        transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointIndex].position,moveSpeed * Time.deltaTime);
        //If Enemy reach position of waypoint, it walked toward
        // then waypointIndex is increased by 1
        if (Vector2.Distance(transform.position, waypoints[waypointIndex].position) < 0.2f){
            if (waitTime <= 0) {
                waypointIndex = Random.Range(0, waypoints.Length);
                waitTime = startWaitTime;
            } else {
                waitTime -= Time.deltaTime;
            }

        }
    }
    
    
}


