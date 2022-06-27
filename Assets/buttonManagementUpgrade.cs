using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManagementUpgrade : MonoBehaviour
{
    public GameObject menuPrincipal;
    public GameObject menuAmelioration;
    public Mouvement speed;
    public degat vie;

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


    public void UpgradeSpeed()
    {
        speed.walkSpeed = speed.walkSpeed * 1.05f;
        PlayerPrefs.SetFloat("moveSpeed", speed.walkSpeed);
        Debug.Log(speed.walkSpeed);
    }

    public void UpgradeJumpSpeed()
    {
        speed.jumpSpeed.y = speed.jumpSpeed.y + 0.2f;
        PlayerPrefs.SetFloat("jumpSpeed", speed.jumpSpeed.y);
        Debug.Log(speed.jumpSpeed);
    }

    public void UpgradeHealth()
    {
        vie.vie = vie.vie + 1;
        PlayerPrefs.SetFloat("vie", vie.vie);
        Debug.Log(vie.vie);
    }
}
