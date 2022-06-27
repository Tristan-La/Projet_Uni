using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramassageBonbon : MonoBehaviour
{
    private int monScore;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("monScore"))
        {
            monScore = PlayerPrefs.GetInt("monScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bonbon")
        {
            Destroy(collision.gameObject);
            monScore++;
        }
        PlayerPrefs.SetInt("monScore", monScore);
    }
}
