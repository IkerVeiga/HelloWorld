using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransform : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform transformation;
    void Start()
    {
        transformation = this.GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = transform.position;
        //Quaternion rotation = transform.rotation;
        //Vector3 scale = transform.localScale;

        //Debug.Log("Posicion: " + position);
        //Debug.Log("Rotacion: " + rotation);
        //Debug.Log("Escala: " + scale);

        printPosition();

    }

    private void printPosition()
    {
        Debug.Log("Posicion en x: " + transformation.localPosition.x);
        Debug.Log("Posicion en y: " + transformation.localPosition.y);
        Debug.Log("Posicion en z: " + transformation.localPosition.z);
    }
}
