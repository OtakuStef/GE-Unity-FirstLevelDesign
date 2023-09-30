using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraSwitcher
{
    static List<CinemachineVirtualCamera> surveillanceCameras = new List<CinemachineVirtualCamera>();

    public static CinemachineVirtualCamera ActiveCamera = null;


    public static bool IsActiveCamera(CinemachineVirtualCamera virtualCamera)
    {
        return virtualCamera == ActiveCamera;
    }

    public static void SwitchCamera(CinemachineVirtualCamera virtualCamera)
    {
        Debug.Log("Switch Camera reached with: " + virtualCamera);

        foreach (CinemachineVirtualCamera c in surveillanceCameras)
        {
            if (c != virtualCamera && c.Priority != 0)
            {
                c.Priority = 0;
            }
        }

        virtualCamera.Priority = 20;
        ActiveCamera = virtualCamera;

    }

    public static void SwitchToPlayer()
    {
        foreach (CinemachineVirtualCamera c in surveillanceCameras)
        {
            ActiveCamera = null;
            c.Priority = 0;
        }
    }

    public static void SwitchBetweenCams(CinemachineVirtualCamera virtualCamera)
    {
        Debug.Log("Switch to other cam triggered from: " + virtualCamera);

        int indexOfCamera = surveillanceCameras.IndexOf(virtualCamera);
        int nextCamera = indexOfCamera + 1;

        if (nextCamera > surveillanceCameras.Count-1)
        {
            changeCameraToNext(0);
        }
        else
        {
            changeCameraToNext(nextCamera);
        }

        virtualCamera.Priority = 0;

    }

    public static void changeCameraToNext(int cameraIndex)
    {
        CinemachineVirtualCamera nextVirtCamera = surveillanceCameras[cameraIndex];
        Debug.Log("Camera to change to: " + nextVirtCamera);
        if (nextVirtCamera != null)
        {
            nextVirtCamera.Priority = 20;
            ActiveCamera = nextVirtCamera;
        }
    }

    public static void Register(CinemachineVirtualCamera virtualCamera)
    {
        surveillanceCameras.Add(virtualCamera);
        Debug.Log("Camera registered: " + virtualCamera);
    }

    public static void Unregister(CinemachineVirtualCamera virtualCamera)
    {
        surveillanceCameras.Remove(virtualCamera);
        Debug.Log("Camera unregistered: " + virtualCamera);
    }

}
