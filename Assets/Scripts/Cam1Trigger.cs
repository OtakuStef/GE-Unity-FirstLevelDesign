using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Cam1Trigger : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam1;
    public GameObject playerCam;
    public GameObject uiObject;

    public bool isTriggered;

    void Start()
    {
        isTriggered = false;
    }

    void Update()
    {
        if (isTriggered)
        {
            if (Input.GetButtonDown("Change Between Cams"))
            {
                uiObject.SetActive(false);
                isTriggered = false;

                if (CameraSwitcher.ActiveCamera != cam1)
                {
                    CameraSwitcher.SwitchCamera(cam1);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiObject.SetActive(true);
            isTriggered = true;
        }
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiObject.SetActive(false);
            isTriggered = false;
        }
    }

}
