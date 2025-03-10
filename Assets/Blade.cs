using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("Obstacle");
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.tag == "Toupie")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            Debug.Log("Toupie");
            if (rb)
            {
                Vector3 v3 = Vector3.zero;
                Transform mT = GetComponentInParent<Transform>();

                Vector3 vect = mT.position - other.GetComponentInParent<Transform>().position;

                v3.x = -vect.x * 1000;
                v3.z = -vect.z * 1000;
                v3.y = 200;
                rb.AddForce(v3);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject);

        }
    }
}
