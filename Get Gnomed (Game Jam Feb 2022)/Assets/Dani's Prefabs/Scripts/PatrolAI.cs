using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolAI : MonoBehaviour
{
    public Animator animator;

    NavMeshAgent agent;

    public Transform player;


    //Patroling    
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;

     
    //Atacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;


    void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
    
    void Start()
    {
       
       // agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
      
    }

    
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            StartCoroutine(Wait());
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        
        agent.SetDestination(target);
    }


    void IterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

    IEnumerator Wait()
    {
        target = waypoints[waypointIndex].position;

        animator.SetBool("Idel", true);

        yield return new WaitForSeconds(5);

        agent.SetDestination(target);

        animator.SetBool("Idel", false);

    }

    void Patroling()
    {
        if (Vector3.Distance(transform.position, target) < 1 )
        {
            IterateWaypointIndex();
            StartCoroutine(Wait());
        }
    }

  

}
