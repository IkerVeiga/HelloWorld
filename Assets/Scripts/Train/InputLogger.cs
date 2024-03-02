using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputLogger : MonoBehaviour
{
    public Object[] allTheGameObjects;
    public int cont = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DestroyGameObjects();
    }

    private void DestroyGameObjects()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Espacio pulsado");
            //Destroy(allTheGameObjects[cont]);
            //cont++;

        }
    }
}
