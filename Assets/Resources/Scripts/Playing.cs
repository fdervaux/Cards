using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playing : MonoBehaviour
{
    public Deck deck1;
    public Deck deck2;
    public Deck deck3;
    public Deck deck4;

    private void Start() {

        GameManager gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        gm.InitDeck(deck1, "TTT");
        gm.InitDeck(deck2, "PPP");
        gm.InitDeck(deck3, "CCC");
        gm.InitDeck(deck4, "KKK");


        Debug.Log(gm.Superior(deck1, deck2));


        // **********************************************
        // **********************************************
        // **********************************************
        gm.StartAnimation();
    }

}