using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y+1, transform.position.z), transform.forward*10, Color.red);

        if(Physics.Raycast(new Vector3(transform.position.x,transform.position.y+1,transform.position.z), transform.forward * 10, out hit, 10))
        {
            Debug.Log("Le raycast touche un objet !");
        }
    }
}
