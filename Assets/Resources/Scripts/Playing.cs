using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playing : MonoBehaviour
{
    public Deck deck1;
    public Deck deck2;
    public Deck deck3;
    public Deck deck4;

    public GameManager gm;

    private void Start() {

        gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        // **********************************************
        // **********************************************
        // **********************************************
        gm.StartAnimation();
    }

}