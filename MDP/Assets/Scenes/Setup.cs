using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setup : MonoBehaviour
{

    public GameObject DefaultFloor;

    private RaycastHit hit;

    public Text info;

    public int x,y;

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;

       Grid[,] objArray = new Grid[x, y]; //creating 2d array
        GameObject[,] displayArray = new GameObject[x, y];


        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                objArray[i, j] = new Grid(new Vector3(i, 0, j), x, y);
                displayArray[i, j] = Instantiate(DefaultFloor, new Vector3(i, 0, j), Quaternion.Euler(90, 0, 0));
                displayArray[i, j].name = string.Format("displayArray[{0}, {1}]",i,j);
            }

        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                info.text += "\nYou selected the " + hit.transform.gameObject.name; 
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.green;

                
            }
        }
    }



}
