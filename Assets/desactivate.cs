using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivate : MonoBehaviour
{
    public GameObject elephant;
    // Start is called before the first frame update
    void Start()
    {
        elephant.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
