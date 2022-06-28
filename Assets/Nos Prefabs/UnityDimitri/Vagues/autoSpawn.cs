using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoSpawn : MonoBehaviour
{
    public GameObject prefab;
    private float spawnRate = 7f;

    private int maxSpawn = 3;
    private int nbSpawn;

    private float nextSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.timeSinceLevelLoad > nextSpawn)
        {

            for (nbSpawn = 0; nbSpawn <= maxSpawn; nbSpawn++)
            {

                nextSpawn = Time.timeSinceLevelLoad + spawnRate;
                GameObject go = Instantiate(prefab, transform.position, Quaternion.identity);
                go.name = "enemie";
            }

            maxSpawn += 2;
        }

    }
}
