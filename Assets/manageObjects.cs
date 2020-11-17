using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageObjects : MonoBehaviour
{
    public GameObject sphere;
    public GameObject torus;
    public GameObject cone;
    public GameObject house;
    public GameObject head;
    public GameObject bellPepper;
    public List<GameObject> objectList = new List<GameObject>();
    public int currentObject = 0;

    public GameObject lightSource;

    public bool rotateLighting = false;
    public bool rotateObject = false;

    void Start()
    {
        objectList.Add(sphere);
        objectList.Add(torus);
        objectList.Add(cone);
        objectList.Add(house);
        objectList.Add(head);
        objectList.Add(bellPepper);
    }

    // Update is called once per frame
    void Update()
    {
        // Cycle object
        if (Input.GetKeyDown("space"))
        {
            if (currentObject < (objectList.Count - 1))
            {
                currentObject = currentObject + 1;
            }
            else
            {
                currentObject = 0;
            }
        }

        // Rotate Lighting
        if (Input.GetKeyDown("left ctrl"))
        {
            rotateLighting = !rotateLighting;
        }

        // Rotate Object
        if (Input.GetKeyDown("left shift"))
        {
            rotateObject = !rotateObject;
        }

        for (int i = 0; i < objectList.Count; i++)
        {
            objectList[i].transform.position = new Vector3(50f, 0f, 0f);
        }
        objectList[currentObject].transform.position = new Vector3(0f, 0f, 0f);

        if (rotateObject)
        {
            objectList[currentObject].transform.Rotate(0f, 0.5f, 0f, Space.World);
        }
        if (rotateLighting)
        {
            lightSource.transform.Rotate(0f, 0.5f, 0f, Space.World);
        }
    }
}
