using UnityEngine;
public enum BloodType
{
    ColdBlooded,
    WarmBlooded
}
public class Animal : MonoBehaviour
{
    protected int health = 100;
    protected int energy = 100;
    protected BloodType bType;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Eat(int energyGained)
    {
        energy += energyGained;
    }
}
