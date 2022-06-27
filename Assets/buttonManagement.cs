using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonManagement : MonoBehaviour
{
    public GameObject menuAmelioration;
    public GameObject menuPrincipal;

    // Start is called before the first frame update
    void Start()
    {
        menuAmelioration.SetActive(false);
    }

    public void Leave()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("Jeu");
    }
    
    public void Upgrade()
    {
        menuPrincipal.SetActive(false);
        menuAmelioration.SetActive(true);
    }

}
