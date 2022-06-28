using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonManagementUpgrade : MonoBehaviour
{
    public GameObject menuPrincipal;
    public GameObject menuAmelioration;
    public MouvementAnime speed;
    public degat vie;
    public Text texteSpeed;
    public Text texteJumpSpeed;
    public Text texteHealth;

    public Text texteButtonUpgradeSpeed;
    public Text texteButtonUpgradeJumpSpeed;
    public Text texteButtonUpgradeHealth;

    private int niveauSpeed;
    private int niveauJumpSpeed;
    private int niveauHealth;


    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("nivSpeed"))
        {
            niveauSpeed = PlayerPrefs.GetInt("nivSpeed");
        }
        else if (!PlayerPrefs.HasKey("nivSpeed"))
        {
            niveauSpeed = 0;
            PlayerPrefs.SetInt("nivSpeed", niveauSpeed);
        }

        if (PlayerPrefs.HasKey("nivJumpSpeed"))
        {
            niveauJumpSpeed = PlayerPrefs.GetInt("nivJumpSpeed");
        }
        else if (!PlayerPrefs.HasKey("nivJumpSpeed"))
        {
            niveauJumpSpeed = 0;
            PlayerPrefs.SetInt("nivJumpSpeed", niveauJumpSpeed);
        }

        if (PlayerPrefs.HasKey("nivHealth"))
        {
            niveauHealth = PlayerPrefs.GetInt("nivHealth");
        }
        else if (!PlayerPrefs.HasKey("nivHealth"))
        {
            niveauHealth = 0;
            PlayerPrefs.SetInt("nivHealth", niveauHealth);
        }




        if (PlayerPrefs.HasKey("moveSpeed"))
        {
            speed.walkSpeed = PlayerPrefs.GetFloat("moveSpeed");
        }

        else if (!PlayerPrefs.HasKey("moveSpeed"))
        {
            speed.walkSpeed = 6f;
            PlayerPrefs.SetFloat("moveSpeed", speed.walkSpeed);
        }

        if (PlayerPrefs.HasKey("moveJumpSpeed"))
        {
            speed.jumpSpeed = new Vector3(0, PlayerPrefs.GetFloat("moveJumpSpeed"), 0);
        }

        else if (!PlayerPrefs.HasKey("moveJumpSpeed"))
        {
            speed.jumpSpeed = new Vector3(0, 5, 0);
            PlayerPrefs.SetFloat("moveJumpSpeed", speed.jumpSpeed.y);
        }

        if (PlayerPrefs.HasKey("vie"))
        {
            vie.vie = PlayerPrefs.GetFloat("vie");
        }
        else if (!PlayerPrefs.HasKey("vie"))
        {
            vie.vie = 5f;
            PlayerPrefs.SetFloat("vie", vie.vie);
        }

        AffichageStats();
    }


    public void UpgradeSpeed()
    {
        if (niveauSpeed >= 10)
        {
            texteButtonUpgradeSpeed.text = "Max";
        }
        else
        {
            speed.walkSpeed = speed.walkSpeed * 1.05f;
            PlayerPrefs.SetFloat("moveSpeed", speed.walkSpeed);
            niveauSpeed++;
            PlayerPrefs.SetInt("nivSpeed", niveauSpeed);
            Debug.Log("niveau : " + PlayerPrefs.GetInt("nivSpeed"));
            Debug.Log(PlayerPrefs.GetFloat("moveSpeed"));
        }
    }

    public void UpgradeJumpSpeed()
    {
        if (niveauJumpSpeed >= 10)
        {
            texteButtonUpgradeJumpSpeed.text = "Max";
        }
        else
        {
            speed.jumpSpeed.y = speed.jumpSpeed.y + 0.2f;
            PlayerPrefs.SetFloat("moveJumpSpeed", speed.jumpSpeed.y);
            niveauJumpSpeed++;
            PlayerPrefs.SetInt("nivJumpSpeed", niveauJumpSpeed);
            Debug.Log("niveau : " + PlayerPrefs.GetInt("nivJumpSpeed"));
            Debug.Log(PlayerPrefs.GetFloat("moveJumpSpeed"));
        }
    }

    public void UpgradeHealth()
    {
        if (niveauHealth >= 10)
        {
            texteButtonUpgradeHealth.text = "Max";
        }
        else
        {
            vie.vie = vie.vie + 1f;
            PlayerPrefs.SetFloat("vie", vie.vie);
            niveauHealth++;
            PlayerPrefs.SetInt("nivHealth", niveauHealth);
            Debug.Log("niveau : " + PlayerPrefs.GetInt("nivHealth"));
            Debug.Log(PlayerPrefs.GetFloat("vie"));
        }
    }


    public void Return()
    {
        menuAmelioration.SetActive(false);
        menuPrincipal.SetActive(true);
    }

    public void ResetUpgrade()
    {
        PlayerPrefs.DeleteKey("moveSpeed");
        PlayerPrefs.DeleteKey("moveJumpSpeed");
        PlayerPrefs.DeleteKey("vie");
        PlayerPrefs.DeleteKey("nivSpeed");
        texteButtonUpgradeSpeed.text = "Upgrade";
        PlayerPrefs.DeleteKey("nivJumpSpeed");
        texteButtonUpgradeJumpSpeed.text = "Upgrade";
        PlayerPrefs.DeleteKey("nivHealth");
        texteButtonUpgradeHealth.text = "Upgrade";
    }

    public void AffichageStats()
    {
        texteSpeed.text = Convert.ToString(Math.Round(PlayerPrefs.GetFloat("moveSpeed"),1));
        texteJumpSpeed.text = Convert.ToString(Math.Round(PlayerPrefs.GetFloat("moveJumpSpeed"),1));
        texteHealth.text = Convert.ToString(PlayerPrefs.GetFloat("vie"));
    }
}
