using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{

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

        //Normaler Arm wird ausgeblendet, solange der Knopf gedr�ckt ist. 
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NormalArm.SetActive(false);
        };

        if (Input.GetKeyUp(KeyCode.Space))
        {
            NormalArm.SetActive(true);
        };



        //Winkender Arm wird angezeigt, solange der Knopf gedr�ckt ist. 
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
