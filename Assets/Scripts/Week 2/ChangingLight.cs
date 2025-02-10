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

    public void newChangeLightColor()
    {
        if (lightWeWantToChange.color == Color.green)
        {
            lightWeWantToChange.intensity = 100f;
        }

        if(lightWeWantToChange.color == Color.blue)
        {
            lightWeWantToChange.gameObject.SetActive(false);

        }

        if (lightWeWantToChange.color == Color.green || lightWeWantToChange.color == Color.red)
        {
            //if the color is green or red it will run the code
        }

        if (lightWeWantToChange.color == Color.blue &&lightWeWantToChange.intensity > 50f)
        {
            // if the color is blue AND intenstity is greater than 50 the code will run
        }

        if (lightWeWantToChange.color == Color.white || (lightWeWantToChange.color == Color.black && lightWeWantToChange. intensity <= 25))
        {
            // if the color is white or the light is black and has an intensity less than or euqal to 25 the code will run

        }
          


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
