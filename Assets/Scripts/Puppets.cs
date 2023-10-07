using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puppets : MonoBehaviour
{
    public AudioSource scareMe;
    public GameObject hiddenPuppets;
    public bool isTriggered;
    public GameObject toHideObject; 
    public GameObject toShowObject;

    // Start is called before the first frame update
    void Start()
    {
        isTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered)
        {
            hiddenPuppets.SetActive(true);
            scareMe.Play();
            isTriggered = true;
            this.OpenExit();
        }
    }

    public void OpenExit()
    {
        toHideObject.SetActive(false);
        toShowObject.SetActive(true); 
    }


    public void OnTriggerExit(Collider other)
    {
        //if (other.CompareTag("Player"))
        //{
        //    hiddenPuppets.SetActive(false);
        //    isTriggered = false;
        //}
    }
}
