using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private const float standardRotation = 50.0f;
    private GameObject cameraObject;
    [SerializeField] private CinemachineVirtualCamera cam1;
    public float rotationSpeed = standardRotation;

    // Start is called before the first frame update
    void Start()
    {
        cameraObject = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraObject.GetComponent<CinemachineBrain>().ActiveVirtualCamera.Name == cam1.Name)
        {
            var rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
            transform.rotation = transform.rotation * Quaternion.Euler(0, rotation, 0);
        }


    }
}
