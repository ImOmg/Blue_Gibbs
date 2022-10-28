using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class extra : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;


    public Transform[] wayPoints;
    private int wayPointIndex;
    private Vector3 target;

    public float timeBetweenAttacks;
    bool alreadyAttacked;

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Patrolling()
    {
        target = wayPoints[wayPointIndex].position;
        agent.SetDestination(target);
    }

    // if waypoint index is equal to the waypoints we have, it'll set it back to 0
    private void SearchWalkPoint()
    {
        wayPointIndex++;
        if (wayPointIndex == wayPoints.Length)
        {
            wayPointIndex = 0;
        }
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void Update()
    {
        //if the distance to the target is less then one meter, it increases the waypoint index by one
        if (Vector3.Distance(transform.position, target) < 1)
        {
            Patrolling();
            SearchWalkPoint();
        }

        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patrolling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInSightRange && playerInAttackRange) AttackPlayer();
    }
}
