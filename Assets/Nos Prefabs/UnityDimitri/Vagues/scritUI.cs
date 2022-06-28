using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scritUI : MonoBehaviour
{

    public GameObject textEnemie;
    public GameObject textVague;
    public GameObject panel;

    private int nbEnemie;
    private int nbEnemieAvant = 0;
    public int nbVague = 0;
    //Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);


    }

    //Update is called once per frame
    void Update()
    {



        Text enemie = textEnemie.GetComponent<Text>();
        Text vague = textVague.GetComponent<Text>();

        nbEnemie = 0;
        foreach (GameObject gameObject in FindObjectsOfType(typeof(GameObject)) as GameObject[])
        {
            if (gameObject.name == "enemie")
            {
                nbEnemie++;
            }
        }
        enemie.text = "Enemies restant : " + nbEnemie;

        if (nbEnemie > nbEnemieAvant)
        {

            nbVague++;

            vague.text = "Vague " + nbVague ;

            nbEnemieAvant = nbEnemie + (nbEnemie - nbEnemieAvant);


            StartCoroutine(waitPanel(2));


        }
    }

    IEnumerator waitPanel(int durre)
    {
        panel.gameObject.SetActive(true);


        yield return new WaitForSeconds(durre);

        panel.gameObject.SetActive(false);

    }

    IEnumerator wait(int durre)
    {


        yield return new WaitForSeconds(durre);


    }
}
