using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClassMonoBehaviour : MonoBehaviour
{
    public Moteur _moteur = null;

    // Start is called before the first frame update
    void Start()
    {
        _moteur = new Moteur(Moteur.MoteurType.Essence, 60);
        Moteur moteur2 = new Moteur(Moteur.MoteurType.Diesel, 120);


        Voiture maVoiture1 = new Voiture("206" , "peugeot", _moteur);
        Voiture maVoiture2 = new Voiture("Clio", "renault", moteur2);

        Debug.Log(_moteur.ToString());

        //maVoiture1.Marque = "test";
        //maVoiture1.marque = "peugeot";
        //maVoiture2.marque = "renault";

        Debug.Log(maVoiture1.ToString());
        Debug.Log(maVoiture2.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
