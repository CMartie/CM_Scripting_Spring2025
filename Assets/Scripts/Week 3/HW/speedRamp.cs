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
      //Vector3 springDirection;

        if(other.gameObject.tag == "speedBump")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 1000f);
            Debug.Log("i am going right");

        }

        if(other.gameObject.tag == "smallBoost")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000f);
            Debug.Log("i am going up slowly");
        }

        if(other.gameObject.tag == "spring1")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 2000f + Vector3.right * 500f);
        }
    }

  /*public void OnCollisionEnter(Collision collision)
    {
        if (other.gameObject.tag == "smallBoost")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 200f);
            Debug.Log("i am going up slowly");
        }
    }*/
}
