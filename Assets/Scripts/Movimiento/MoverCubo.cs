using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoverCubo : MonoBehaviour
{
    public Vector3 position;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        CreateObjectAndSetParent();
    }

    private void CreateObjectAndSetParent()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
        Move();
        Scale();
        Rotate();
    }

    private void LogPosition()
    {
        position = GetComponent<Transform>().localPosition;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("(" + position.x + "; " + position.y + "; " + position.z + ")");
        }
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.localPosition += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.localPosition += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.localPosition += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.localPosition += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.localPosition += Vector3.down * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.localPosition += Vector3.up * Time.deltaTime * speed;
        }
    }

    private void Scale()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.localScale += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.X))
        {
            this.transform.localScale += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.C))
        {
            this.transform.localScale += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.V))
        {
            this.transform.localScale += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.B))
        {
            this.transform.localScale += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.N))
        {
            this.transform.localScale += Vector3.down * Time.deltaTime * speed;
        }
    }

    private void Rotate()
    {
        this.transform.rotation *= Quaternion.Euler(0, 1 * speed * Time.deltaTime, 0);
        //transform.Rotate(new Vector3(0, 180, 0));
    }
}
