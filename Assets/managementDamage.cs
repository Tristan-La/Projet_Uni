using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managementDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int longueur = GameObject.FindGameObjectsWithTag("animaux").Length;
        GameObject[] lesAnimaux = new GameObject[longueur - 1];
        lesAnimaux = GameObject.FindGameObjectsWithTag("animaux");

        gameObject.GetComponent<Text>().text = "Vie : " + lesAnimaux[0].GetComponent<degat>().vie;
    }
}
