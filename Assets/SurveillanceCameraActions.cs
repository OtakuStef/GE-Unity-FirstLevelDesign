using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurveillanceCameraActions : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam1;
    [SerializeField] private CinemachineVirtualCamera cam2;
    [SerializeField] private CinemachineVirtualCamera cam3;
    [SerializeField] private CinemachineVirtualCamera cam4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cam1.Priority > 0 || cam2.Priority > 0 || cam3.Priority > 0 || cam4.Priority > 0)
        {
            if (Input.GetButtonDown("Change Between Cams"))
            {
                CameraSwitcher.SwitchToPlayer();
            }

            if (Input.GetButtonDown("Cam1"))
            {
                CameraSwitcher.SwitchCamera(cam1);

            }
            if (Input.GetButtonDown("Cam2"))
            {
                CameraSwitcher.SwitchCamera(cam2);

            }
            if (Input.GetButtonDown("Cam3"))
            {
                CameraSwitcher.SwitchCamera(cam3);

            }
            if (Input.GetButtonDown("Cam4"))
            {
                CameraSwitcher.SwitchCamera(cam4);

            }
        }

    }

}
