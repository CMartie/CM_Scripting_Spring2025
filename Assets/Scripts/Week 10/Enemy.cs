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

    protected List<Transform> patrolPoints = new List<Transform> ();

    protected int patrolPointIndex = 0;

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

        if(hasSeenPlayer == true)
        {
            if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)
            {


                attackTimer += Time.deltaTime;

                if (attackTimer > attackSpeed)
                {
                    Attack();
                    attackTimer = 0;

                }
            }

            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)
            {
                navAgent.SetDestination(player.transform.position);
                navAgent.isStopped = false;

            }
            else
            {
                RaycastHit hit;

                Vector3 dir = player.transform.position - this.transform.position;
                dir.Normalize();

                //Debug.Log(hit.collider.name);

                if (Physics.Raycast(this.transform.position, dir, out hit))
                {
                    Debug.Log(hit.collider.name);

                    if (hit.collider.tag == "Player")
                    {
                        navAgent.isStopped = true;
                        this.transform.LookAt(player.transform.position);

                        // if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)
                        //{


                        attackTimer += Time.deltaTime;

                        if (attackTimer > attackSpeed)
                        {
                            Attack();
                            attackTimer = 0;

                            //}
                        }
                    }
                    else
                    {
                        navAgent.SetDestination(player.transform.position);
                        navAgent.isStopped = false;
                    }
                }
            }
       

        }
        else
        {
            if(navAgent.remainingDistance < 0.5f)
            {
                patrolPointIndex++;

                if(patrolPointIndex < patrolPoints.Count)
                {
                    patrolPointIndex = 0;
                }

                navAgent.SetDestination(patrolPoints[patrolPointIndex].position);

            }
        }


    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            hasSeenPlayer = true;
        }
    }

    public virtual void SeePlayer()
    {
        RaycastHit hit;

        Vector3 dir = player.transform .position - this.transform.position;

        dir.Normalize();

        if(Physics.Raycast(this.transform.position , dir, out hit))
        {
            if(hit.collider.tag == "Player")
            {
                hasSeenPlayer = true;
            }
        }
        else
        {
            hasSeenPlayer = false;
        }
       
    }



   
    
}
