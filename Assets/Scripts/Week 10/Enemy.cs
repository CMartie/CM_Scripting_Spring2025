using Unity.VisualScripting;
using UnityEngine;
using UnityEngine. AI;
using UnityEngine.UI;
using System.Collections.Generic;



public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;
    public float attackSpeed;

    private float attackTimer;

    protected Player player;

    protected NavMeshAgent navAgent;

    protected bool hasSeenPlayer = false;

    [SerializeField]

    protected List<Transform> patrolPoints = new List<Transform>();

    protected int patrolPointIndex = 0;

    [SerializeField]
    protected float aggroRange = 15f;

    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
    }

    protected virtual void Attack()
    {
        //Call an animation
        //Deal damage to player
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }

    public void Die()
    {
        //play death animation
        //or destroy object
    }

    protected virtual void Update()
    {
        //navAgent.SetDestination(player.transform.position);

        if (hasSeenPlayer == true)
        {
            if (navAgent.remainingDistance < 0.5f) //enemy reached last known location of the player
            {
                if (Vector3.Distance(this.transform.position, this.transform.position) > aggroRange) //
                {
                    hasSeenPlayer = false;
                }
            }
            else //they are not out of aggro range
            {
                if(isPlayerInLineOfSight()== true) // if player is within line of sight
                {
                    navAgent.SetDestination(player.transform.position);
                    navAgent.isStopped = false; //enemy will see player and will chase them
                }
            }
            //if the player is within attack range 
            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)
            {
                RaycastHit hit; // and if the player is within line of sight

                Vector3 dir = player.transform.position - this.transform.position;
                dir.Normalize();


                if (Physics.Raycast(this.transform.position, dir, out hit))
                {
                    if (hit.collider.tag == "Player")
                    {
                        navAgent.SetDestination(player.transform.position);
                        navAgent.isStopped = false;
                    }

                }

            }
            else //if the player is within attack range
            {
                RaycastHit hit; //and in line of sight

                Vector3 dir = player.transform.position - this.transform.position;
                dir.Normalize();


                if (Physics.Raycast(this.transform.position, dir, out hit))
                {
                    Debug.Log(hit.collider.name);

                    if (hit.collider.tag == "Player")
                    {
                        navAgent.isStopped = true; //stop nav movements
                        this.transform.LookAt(player.transform.position); //look at player



                        attackTimer += Time.deltaTime; //increase attack timer

                        if (attackTimer > attackSpeed) //once attack timer reaches the attack speed
                        {
                            Attack(); //attack!
                            attackTimer = 0; //reset timer

                            
                        }
                    }
                   
                }
               // else
               // {
               //     navAgent.isStopped = false;
               // }
            }


        }
        else //if the player has not been seen
        {
            if (navAgent.remainingDistance < 0.5f) // of tje navagent reacjes ots destination
            {
                patrolPointIndex++; //increase the patrol point indec=x so it will move

                if (patrolPointIndex >= patrolPoints.Count) //if the point is out of range
                {
                    patrolPointIndex = 0; //reset to 0
                }

                navAgent.SetDestination(patrolPoints[patrolPointIndex].position); //set destination to determined point
                navAgent.isStopped = false;
            }
        }


    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            hasSeenPlayer = true;
        }
    }

    public virtual void SeePlayer()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;

        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                hasSeenPlayer = true;
            }
        }
        else
        {
            hasSeenPlayer = false;
        }

    }

    protected bool isPlayerInLineOfSight()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();


        if (Physics.Raycast(this.transform.position, dir, out hit))
        {

            if (hit.collider.tag == "Player")
            {
                return true;
            }

        }

        return false;
    }
}
