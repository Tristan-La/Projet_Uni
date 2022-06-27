using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    [SerializeField] GameObject animal1;
    [SerializeField] GameObject animal2;
    [SerializeField] GameObject animal3;
    [SerializeField] GameObject animal4;
    [SerializeField] GameObject animal5;
    // Start is called before the first frame update
    void Start()
    {
        List<GameObject>lesAnimaux = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            int longueur = GameObject.FindGameObjectsWithTag("animaux").Length;
            GameObject[] lesAnimaux = new GameObject[longueur-1];
            lesAnimaux = GameObject.FindGameObjectsWithTag("animaux");
            foreach (GameObject go in lesAnimaux)
                go.SetActive(false);
            animal1.transform.position = new Vector3(lesAnimaux[0].transform.position.x, lesAnimaux[0].transform.position.y, lesAnimaux[0].transform.position.z);
            animal1.transform.rotation = new Quaternion(lesAnimaux[0].transform.rotation.x, lesAnimaux[0].transform.rotation.y, lesAnimaux[0].transform.rotation.z, lesAnimaux[0].transform.rotation.w);
            animal1.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            int longueur = GameObject.FindGameObjectsWithTag("animaux").Length;
            GameObject[] lesAnimaux = new GameObject[longueur - 1];
            lesAnimaux = GameObject.FindGameObjectsWithTag("animaux");
            foreach (GameObject go in lesAnimaux)
                go.SetActive(false);
            animal2.transform.position = new Vector3(lesAnimaux[0].transform.position.x, lesAnimaux[0].transform.position.y, lesAnimaux[0].transform.position.z);
            animal2.transform.rotation = new Quaternion(lesAnimaux[0].transform.rotation.x, lesAnimaux[0].transform.rotation.y, lesAnimaux[0].transform.rotation.z, lesAnimaux[0].transform.rotation.w);
            animal2.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            int longueur = GameObject.FindGameObjectsWithTag("animaux").Length;
            GameObject[] lesAnimaux = new GameObject[longueur - 1];
            lesAnimaux = GameObject.FindGameObjectsWithTag("animaux");
            foreach (GameObject go in lesAnimaux)
                go.SetActive(false);
            animal3.transform.position = new Vector3(lesAnimaux[0].transform.position.x, lesAnimaux[0].transform.position.y, lesAnimaux[0].transform.position.z);
            animal3.transform.rotation = new Quaternion(lesAnimaux[0].transform.rotation.x, lesAnimaux[0].transform.rotation.y, lesAnimaux[0].transform.rotation.z, lesAnimaux[0].transform.rotation.w);
            animal3.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            int longueur = GameObject.FindGameObjectsWithTag("animaux").Length;
            GameObject[] lesAnimaux = new GameObject[longueur - 1];
            lesAnimaux = GameObject.FindGameObjectsWithTag("animaux");
            foreach (GameObject go in lesAnimaux)
                go.SetActive(false);
            animal4.transform.position = new Vector3(lesAnimaux[0].transform.position.x, lesAnimaux[0].transform.position.y, lesAnimaux[0].transform.position.z);
            animal4.transform.rotation = new Quaternion(lesAnimaux[0].transform.rotation.x, lesAnimaux[0].transform.rotation.y, lesAnimaux[0].transform.rotation.z, lesAnimaux[0].transform.rotation.w);
            animal4.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            int longueur = GameObject.FindGameObjectsWithTag("animaux").Length;
            GameObject[] lesAnimaux = new GameObject[longueur - 1];
            lesAnimaux = GameObject.FindGameObjectsWithTag("animaux");
            foreach (GameObject go in lesAnimaux)
                go.SetActive(false);
            animal5.transform.position = new Vector3(lesAnimaux[0].transform.position.x, lesAnimaux[0].transform.position.y, lesAnimaux[0].transform.position.z);
            animal5.transform.rotation = new Quaternion(lesAnimaux[0].transform.rotation.x, lesAnimaux[0].transform.rotation.y, lesAnimaux[0].transform.rotation.z, lesAnimaux[0].transform.rotation.w);
            animal5.SetActive(true);
        }
    }
}
