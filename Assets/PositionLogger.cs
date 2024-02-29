using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLogger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherGameObject;
    private Transform transformation;
    void Start()
    {
        //GameObject cube = GameObject.Find("Cube");
        transformation = otherGameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        printPosition();
    }

    private void printPosition()
    {
        Debug.Log("Posicion en x: " + transformation.localPosition.x);
        Debug.Log("Posicion en y: " + transformation.localPosition.y);
        Debug.Log("Posicion en z: " + transformation.localPosition.z);
    }
}
