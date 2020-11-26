using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor
{
    public enum MotorType
    {
        Diesel,
        Essence
    }

    private MotorType _type; // diesel ou essence
    private int _puissance; //ch

    public Motor(MotorType type, int puissance)
    {
        _type = type;
        _puissance = puissance;
    }

    override public string ToString()
    {
        return _type + "/" + _puissance + "ch";
    }

    ~Motor()
    {
        Debug.Log("moteur " + ToString() + " is Destroy");
    }
}


public class Voiture
{
    private string _modele = "default";
    private string _marque = "default";
    
    private Motor _moteur = null;

    
    public string getModele()
    {
        return _modele;
    }

    public void setModele( string modele)
    {
        _modele = modele;
    }

    public Voiture(string modele, string marque, Motor.MotorType type, int puissance)
    {
        _modele = modele;
        _marque = marque;
        _moteur = new Motor(type, puissance);
    }

    public Voiture(string modele, string marque, Motor motor)
    {
        _modele = modele;
        _marque = marque;
        _moteur = motor;
    }

    override public string ToString()
    {
        return _marque + "/" + _modele + "/" + _moteur.ToString();
    }

    ~Voiture()
    {
        Debug.Log("Ma voiture" + _marque+ "/" + _modele + " is destroy");
    }
}



public class ClassExample : MonoBehaviour
{
    private Motor _motor = null;

    // Start is called before the first frame update
    void Start()
    {
        Voiture maVoiture = new Voiture( "Clio3" , "Renault", Motor.MotorType.Diesel, 60);

        _motor = new Motor(Motor.MotorType.Essence, 120);
        Voiture maVoiture2 = new Voiture("multiPlat", "Fiat", _motor);

        //maVoiture.modele = "Clio3";

        Debug.Log(maVoiture.ToString());
        Debug.Log(maVoiture2.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
