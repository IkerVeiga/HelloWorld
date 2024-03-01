using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;

public class ColorChangerByTag : MonoBehaviour
{
    public Color color;
    public bool findByTag;
    public string chosenTag;
    private GameObject[] gameObjects;
    private MeshRenderer[] meshList;
    // Start is called before the first frame update
    void Start()
    {
       gameObjects = GameObject.FindGameObjectsWithTag(chosenTag);
    }

    // Update is called once per frame
    void Update()
    {
        ColorObjects();
    }

    private void ColorObjects()
    {
        if (findByTag)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = color;
            }
        } else 
        {
            meshList = GameObject.FindObjectsOfType<MeshRenderer>();
            foreach (MeshRenderer meshRenderer in meshList)
            {
                meshRenderer.material.color = color;
            }
        }
    }
}
