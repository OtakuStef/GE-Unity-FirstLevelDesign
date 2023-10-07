using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExitTrigger
{
    public static GameObject[] toHideObjects = GameObject.FindGameObjectsWithTag("HideOnExit");
    public static GameObject[] toShowObjects = GameObject.FindGameObjectsWithTag("ShowOnExit");

    public static void OpenExit()
    {
        Debug.Log("Objects to Hide: " + toHideObjects.Length);
        Debug.Log("Objects to Show: " + toShowObjects.Length);
        for (int i = 0; i < toHideObjects.Length; i++) { toHideObjects[i].SetActive(false); }
        for (int i = 0;i < toShowObjects.Length; i++) { toShowObjects[i].SetActive(true); } 
    }
}
