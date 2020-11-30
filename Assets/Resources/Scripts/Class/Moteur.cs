using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moteur
{
    public enum MoteurType
    {
        Default,
        Electrique,
        GPL,
        Essence,
        Diesel,
    }


    private MoteurType _moteurType = MoteurType.Default;
    private int _puissance = 0; //ch

    public int Puissance { get => _puissance; set => _puissance = value; }

    public Moteur(MoteurType moteurType, int puissance)
    {
        _moteurType = moteurType;
        _puissance = puissance;
    }

    public override string ToString()
    {
        return _moteurType.ToString() + " " + _puissance.ToString() + "ch";
    }

    ~Moteur()
    {
        Debug.Log(ToString() + " est détruit");
    }

}

