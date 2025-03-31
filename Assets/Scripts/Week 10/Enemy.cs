using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;
    public float attackSpeed;

    public float attackTimer;

    protected Player player;

    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
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
        if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)
        {
           
            attackTimer += Time.deltaTime;

            if(attackTimer > attackSpeed)
            {
                Attack();
            }
        }
    }

    
    
}
