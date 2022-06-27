using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SciptPos : MonoBehaviour
{
    Vector3 vector = new Vector3(247, 4, 194);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = vector;
    }
}
