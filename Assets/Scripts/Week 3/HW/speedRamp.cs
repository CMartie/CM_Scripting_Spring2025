using UnityEngine;

public class speedRamp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "speedBump")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 500f);

        }
    }
}
