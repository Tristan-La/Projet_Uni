using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changementTouches : MonoBehaviour
{

    public MouvementAnime mouvement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextF_Change(string control)
    {
        mouvement.moveFront = control;
    }
    public void TextB_Change(string control)
    {
        mouvement.moveBack = control;
    }
    public void TextL_Change(string control)
    {
        mouvement.moveLeft = control;
    }
    public void TextR_Change(string control)
    {
        mouvement.moveRight = control;
    }
    public void TextRun_Change(string control)
    {
        mouvement.run = control;
    }
    public void TextDash_Change(string control)
    {
        mouvement.dash = control;
    }
}
