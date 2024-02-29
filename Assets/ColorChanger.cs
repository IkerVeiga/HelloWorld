using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TerrainUtils;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Color color;
    void Start()
    {

        this.GetComponent<MeshRenderer>().material.color = color;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
