using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voiture
{
    private string _modele = "defaultModel";
    private string _marque = "defaultMarque";
    private Moteur _moteur = null;

    public string Marque
    {
        get { return _marque; }
        set
        {
            if (value == "peugeot" || value == "Renault")
                _marque = value;
            else
                Debug.LogError("invalid marque");
        }
    }

    public string Modele
    {
        get => _modele;
        set => _modele = value;
    }

    public Voiture(string modele, string marque, Moteur moteur)
    {
        _modele = modele;
        _marque = marque;
        _moteur = moteur;
    }

    public string GetMarque()
    {
        return _marque;
    }

    public void SetMarque(string value)
    {
        if (value == "peugeot" || value == "Renault")
            _marque = value;
        else
            Debug.LogError("invalid marque");
    }

    public string GetModele()
    {
        return _modele;
    }

    public override string ToString()
    {
        return _marque.ToString() + " " + _modele.ToString() + " " + _moteur.ToString();
    }


    ~Voiture()
    {
        Debug.Log(ToString() + " est détruit");
    }
}
