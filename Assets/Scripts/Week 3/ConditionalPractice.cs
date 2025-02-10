using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;

    public GameObject go2;

    public Color go2ElseColor;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName();
        ColorGameObjectByTag();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ColorGameObjectByName()
    {
        Debug.Log("go is named" + go.name);
        Debug.Log("go2 is named" + go2.name);

        //if we create a local variable in the function that does the GetCompnent call once, we can use this variable multiple times that refers to this objects specific 
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();


        if(go.name == "Cube")
        {
            go.GetComponent<MeshRenderer>().material.color = Color.magenta;

            //change color to magenta
        }

       else if(go.name == "Sphere")
        {
            go.GetComponent<MeshRenderer>().material.color = Color.cyan;

            //change the color to cyan
        }

        else if (go.name == "cylinder")
        {
            goMeshRenderer.material.color = Color.black;

            //change color to black
        }

        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //change the color to orange
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();
        if(go2.name == "Cube")
        {
            go2MeshRenderer.material.color = Color.white;

        }
        if(go2.name == "Sphere")
        {
            go2MeshRenderer.material.color = Color.grey;
        }
        if (go2.name == "Cylinder")
        {
            go2MeshRenderer.material.color = Color.blue;
        }
        else
        {
           // go2MeshRenderer.material.color
        }
    }

    void ColorGameObjectByTag()
    { 
        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.tag == "CoolGuy")
        {
            go.GetComponent<MeshRenderer>().material.color = Color.magenta;

            //change color to magenta
        }

        else if (go.tag == "NotCoolGuy")
        {
            go.GetComponent<MeshRenderer>().material.color = Color.cyan;

            //change the color to cyan
        }

        else if (go.tag == "OKGuy")
        {
            goMeshRenderer.material.color = Color.black;

            //change color to black
        }

        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //change the color to orange
        }

       
        if (go2.tag == "CoolGuy")
        {
            go2MeshRenderer.material.color = Color.white;

        }
        if (go2.tag == "NotCoolGuy")
        {
            go2MeshRenderer.material.color = Color.grey;
        }
        if (go2.tag == "OKGuy")
        {
            go2MeshRenderer.material.color = Color.blue;
        }
        else
        {
            go2MeshRenderer.material.color = go2ElseColor;

        }
    }



}
