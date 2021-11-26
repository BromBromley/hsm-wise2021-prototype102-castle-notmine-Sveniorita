using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{

    //Hintergrund f�hrt von rechts nach links durch das Bild, Player l�uft auf der Stelle
    //Random Geist spawnd und f�hrt von rechts nach links durch das Bild
    //Geist reagiert auf das Winken und T�r �ffnet sich - Level geschafft


    // Arme initialisieren
    public GameObject NormalArm;
    public GameObject WaveArm;

 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

 

        //Normaler Arm wird ausgeblendet, solange Leertaste gedr�ckt ist. 

        if (Input.GetKeyDown(KeyCode.Space))
        {
            NormalArm.SetActive(false);
        };

        if (Input.GetKeyUp(KeyCode.Space))
        {
            NormalArm.SetActive(true);
        };



        //Winkender Arm wird angezeigt, solange die Leertaste gedr�ckt ist. 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WaveArm.SetActive(true);
        };

        if (Input.GetKeyUp(KeyCode.Space))
        {
            WaveArm.SetActive(false);
        };


    }

    

}
