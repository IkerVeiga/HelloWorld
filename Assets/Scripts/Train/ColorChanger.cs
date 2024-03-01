using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColorChanger1 : MonoBehaviour
{
    public bool findByTag;
    public string chosenTag;
    public Color color;
    public GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(chosenTag);
    }

    // Update is called once per frame
    void Update()
    {
        if (findByTag)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = color;
            }
        }
    }
}
