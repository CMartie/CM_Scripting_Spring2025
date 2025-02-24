using UnityEngine;

public class spawnCannonBall : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public Transform cannonBallSpawnPosition;
    public int forcePower;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /*  if(Input.GetKeyDown(KeyCode.Space))
        {
            fireCannon();

           // GameObject go = Instantiate(cannonBallPrefab, cannonBallSpawnPosition.position, cannonBallSpawnPosition.rotation);

            //go.GetComponent<Rigidbody>().AddForce(go.transform.forward * forcePower);

        }*/
    }

    public void fireCannon()
    {
        GameObject go = Instantiate(cannonBallPrefab, cannonBallSpawnPosition.position, cannonBallSpawnPosition.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * forcePower);
    }
}
