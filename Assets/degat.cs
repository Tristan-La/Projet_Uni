using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class degat : MonoBehaviour
{
    public int degatAnimal = 1;
    public float vie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(collision.gameObject.name + " est entré");
            collision.gameObject.GetComponent<degat>().vie = collision.gameObject.GetComponent<degat>().vie - degatAnimal;
            Debug.Log("L animal " + collision.gameObject.name + " a " + collision.gameObject.GetComponent<degat>().vie + " vie");
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(collision.gameObject.name + " est dedans");
            collision.gameObject.GetComponent<degat>().vie = collision.gameObject.GetComponent<degat>().vie - degatAnimal;
            Debug.Log("L animal " + collision.gameObject.name + " a " + collision.gameObject.GetComponent<degat>().vie + " vie");
        }
    }
}
