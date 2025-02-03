using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChangingLight : MonoBehaviour
{
    public Light lightWeWantToChange;

    public Vector3 lightMoveDirection;

    public bool isItorIsntIt = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.green);

        lightWeWantToChange.color = Color.green;

       //his.gameObject.SetActive(isItorIsntIt);

        //ghtWeWantToChange.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        AdjustLight();

        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeLightColor(Color.red);

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeLightColor(Color.blue);

        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            lightWeWantToChange.gameObject.SetActive(false);

        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            lightWeWantToChange.gameObject.SetActive(true);

        }
        



       
    }

    private void AdjustLight()
    {
        lightWeWantToChange.transform.position += lightMoveDirection * Time.deltaTime;

        lightWeWantToChange.intensity += 40f * Time.deltaTime;

        lightWeWantToChange.spotAngle += 10f * Time.deltaTime;
    }

    public void ChangeLightColor(Color color)
    {
        lightWeWantToChange.color = color;
    }

    



    private void OnEnable()
    {
        //when this object is set to active again from inactive it will call the ode in this fucntion
    }


    private void OnDisable()
    {
        // When this object is disabled run the code in here before it is disabled
    }

    private void Awake()
    {
        //Is called before start
    }

    private void OnDestroy()
    {
        //this is called when an object is going to be destroyed before the object is destroyed
    }
} 
