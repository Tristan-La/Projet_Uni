using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformationVF : MonoBehaviour
{
    [SerializeField] GameObject animal1;
    [SerializeField] GameObject animal2;
    [SerializeField] GameObject animal3;
    [SerializeField] GameObject animal4;
    [SerializeField] GameObject animal5;
    [SerializeField] GameObject animationTransformatio;
    [SerializeField] GameObject boule;

    private GameObject[] lesAnimaux;
    // Start is called before the first frame update
    void Start()
    {
        lesAnimaux = GameObject.FindGameObjectsWithTag("animaux");

        foreach (GameObject go in lesAnimaux)
            go.SetActive(false);

        lesAnimaux[0].SetActive(true);
        boule.SetActive(false);

        animationTransformatio.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            GameObject ancien =cherche();
            desactive();

            animal1.transform.position = new Vector3(ancien.transform.position.x, ancien.transform.position.y, ancien.transform.position.z);
            animal1.transform.rotation = new Quaternion(ancien.transform.rotation.x, ancien.transform.rotation.y, ancien.transform.rotation.z, ancien.transform.rotation.w);

            StartCoroutine(wait(1, animal1));


        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            GameObject ancien =cherche();
            desactive();

            animal2.transform.position = new Vector3(ancien.transform.position.x, ancien.transform.position.y, ancien.transform.position.z); ;
            animal2.transform.rotation = new Quaternion(ancien.transform.rotation.x, ancien.transform.rotation.y, ancien.transform.rotation.z, ancien.transform.rotation.w);

            StartCoroutine(wait(1, animal2));


        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            GameObject ancien =cherche();
            desactive();

            animal3.transform.position = new Vector3(ancien.transform.position.x, ancien.transform.position.y, ancien.transform.position.z);
            animal3.transform.rotation = new Quaternion(ancien.transform.rotation.x, ancien.transform.rotation.y, ancien.transform.rotation.z, ancien.transform.rotation.w);

            StartCoroutine(wait(1, animal3));



        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            GameObject ancien =cherche();
            desactive();

            animal4.transform.position = new Vector3(ancien.transform.position.x, ancien.transform.position.y, ancien.transform.position.z);
            animal4.transform.rotation = new Quaternion(ancien.transform.rotation.x, ancien.transform.rotation.y, ancien.transform.rotation.z, ancien.transform.rotation.w);

            StartCoroutine(wait(1, animal4));





        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            GameObject ancien =cherche();
            desactive();
            
            animal5.transform.position = new Vector3(ancien.transform.position.x, ancien.transform.position.y, ancien.transform.position.z);
            animal5.transform.rotation = new Quaternion(ancien.transform.rotation.x, ancien.transform.rotation.y, ancien.transform.rotation.z, ancien.transform.rotation.w);

            StartCoroutine( wait(1,animal5));
            


        }
    }

    IEnumerator wait(int durre,GameObject animal)
    {

        animationTransformatio.transform.position = new Vector3(animal.transform.position.x, animal.transform.position.y, animal.transform.position.z);
        boule.transform.position = new Vector3(animal.transform.position.x, animal.transform.position.y, animal.transform.position.z);
        boule.transform.rotation = new Quaternion(animal.transform.rotation.x, animal.transform.rotation.y, animal.transform.rotation.z, animal.transform.rotation.w);

        animationTransformatio.SetActive(true);
        boule.SetActive(true);


        yield return new WaitForSeconds(durre);

        boule.SetActive(false);

        animationTransformatio.SetActive(false);
        animal.SetActive(true);





    }



    public void desactive()
    {
        
        foreach (GameObject go in lesAnimaux)
            go.SetActive(false);
    }

    public GameObject cherche()
    {

        GameObject go = GameObject.FindGameObjectWithTag("animaux");
        return go;
    }
    
    
}
