using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    GameObject clone;
    Rigidbody clone_rb;
    public GameObject bullet;
    void Start()
    {

        
    }
    void Update()
    {       
        

        if(Input.GetKeyDown("space"))
        {            
            clone = Instantiate(bullet, transform.position, Quaternion.Euler(90f+transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0));
            clone_rb = clone.GetComponent<Rigidbody>();
            clone_rb.AddForce(transform.forward * 2000f);
        }
    }
}
