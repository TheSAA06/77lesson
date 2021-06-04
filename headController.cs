using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headController : MonoBehaviour
{
    Transform head_tr;
    float MouseX;
    float MouseY;
    public float sens = 3f;
    
    public GameObject firstCam;
    public GameObject secondCam;
    bool isActive = false;
    void Start()
    {
        head_tr = GetComponent<Transform>();
    }


    void Update()
    {
        MouseX = MouseX - Input.GetAxis("Mouse Y") * sens;
        MouseY = MouseY + Input.GetAxis("Mouse X") * sens;

        MouseX = Mathf.Clamp(MouseX, -90, 90);

        head_tr.rotation = Quaternion.Euler(MouseX, MouseY, 0);

        FindObjectOfType<playerControlller>().GetRotate(MouseY);
        if(Input.GetKeyDown("c"))
        {
            isActive = !isActive;
            secondCam.SetActive(isActive);
            firstCam.SetActive(!isActive);
        }
    }
    

}