using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Voiture
{
    public string modele = "";

}



public class ClassExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Voiture maVoiture = new Voiture();

        Debug.Log(maVoiture.modele);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
