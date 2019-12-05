Ninjia Escape game is inspire by PacMan. We use the Unity to built the game with C# language. 
There are 2 characters we need to create for game - Ninjia and Enemy. Another, we can create the scores like counting the coins,
hearts also. 
Ninja run away the Enemy
Both Ninjia and Enemy need animation and movement.
We can use the keyboard to control direction of the player - left, right, up, down 
 
 movement.x = Input.GetAxisRaw("Horizontal");
 movement.y = Input.GetAxisRaw("Vertical");

And formula of moving

rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

Enemy follow the way point we set 
We create the empty Game Object and named Waypoint. And then, put it on the maze where you want the enemy move to. 
Enemy have the wait time when they reach the point like 0.02s

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
                
When enemy catch the ninja, Ninjia will be killed and the game start over again.


public void Death ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
if (co.GetComponent<EnemyMove>())
        {
            Destroy(gameObject);
            Death();
 
 

