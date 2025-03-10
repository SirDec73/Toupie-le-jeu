using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform transform;
    float speedRotation = 0.1f;
    Quaternion q;
    Vector3 vector3 = Vector3.zero;
    public int speed = 10;

    public string up;
    public string down;
    public string left;
    public string right;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        q = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(left))
        {
            float newX = transform.position.x - speed * Time.deltaTime;
            Vector3 p = Vector3.zero;
            p.x = newX;
            p.y = transform.position.y;
            p.z = transform.position.z;
            transform.position = p;
        }
        if (Input.GetKey(right))
        {
            float newX = transform.position.x + speed * Time.deltaTime;
            Vector3 p = Vector3.zero;
            p.x = newX;
            p.y = transform.position.y;
            p.z = transform.position.z;
            transform.position = p;
        }
        if (Input.GetKey(up))
        {
            float newZ = transform.position.z + speed * Time.deltaTime;
            Vector3 p = Vector3.zero;
            p.x = transform.position.x;
            p.y = transform.position.y;
            p.z = newZ;
            transform.position = p;
        }
        if (Input.GetKey(down))
        {
            float newZ = transform.position.z - speed * Time.deltaTime;
            Vector3 p = Vector3.zero;
            p.x = transform.position.x;
            p.y = transform.position.y;
            p.z = newZ;
            transform.position = p;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 v3 = Vector3.zero;
            v3.y = 10;
            GetComponent<Rigidbody>().AddForce(v3);
        }

        speedRotation += Time.deltaTime;
        vector3.y += speedRotation;
        q = Quaternion.Euler(vector3);
        transform.rotation = q;
    }
}