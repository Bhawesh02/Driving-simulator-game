using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject FirstPersonCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            if (MainCamera.activeSelf)
            {
                MainCamera.SetActive(false);
                FirstPersonCamera.SetActive(true);
            }
            else
            {
                MainCamera.SetActive(true);
                FirstPersonCamera.SetActive(false);
            }
        }
    }
}