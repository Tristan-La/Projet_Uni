using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    [SerializeField] float rotationX;
    [SerializeField] float rotationY;
    private float sensitivity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y")*sensitivity;
        rotationY += Input.GetAxis("Mouse X")*sensitivity;

        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
}
