using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManagementUpgrade : MonoBehaviour
{
    public GameObject menuPrincipal;
    public GameObject menuAmelioration;

    public void Return()
    {
        menuAmelioration.SetActive(false);
        menuPrincipal.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
