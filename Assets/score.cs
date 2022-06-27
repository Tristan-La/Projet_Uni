using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int monScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.HasKey("monScore"))
        {
            monScore = PlayerPrefs.GetInt("monScore");
        }
        else
        {
            monScore = 0;
        }

        gameObject.GetComponent<Text>().text = "Score : "+ monScore;
    }
}
