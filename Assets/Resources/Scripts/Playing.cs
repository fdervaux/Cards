using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playing : MonoBehaviour
{
    public Deck deck1;
    public Deck deck2;
    public Deck deck3;
    public Deck deck4;
    private GameManager gm = null;
    
    public void ViderDeck(Deck deckDepart, Deck deckDArriver)
    {
        while (!gm.DeckIsEmpty(deckDepart))
        {
            gm.MoveTopCard(deckDepart, deckDArriver);
        }
    }

    public void exerciceA6()
    {
        gm.InitDeck(deck1, "T+P");

        if (gm.topCardColor(deck1) == CardColor.Treffle)
        {
            gm.MoveTopCard(deck1, deck2);
        }
        else if (gm.topCardColor(deck1) == CardColor.Pique)
        {
            gm.MoveTopCard(deck1, deck3);
        }
    }
    public void exerciceA7()
    {
        gm.InitDeck(deck1, "(T+K+C+P)(T+K+C+P)");

        gm.MoveTopCard(deck1, deck2); // On déplace la carte du deck 1 sur le deck 2

        if (gm.Superior(deck1, deck2)) // si carte du deck1 est superieur à celle du deck 2
        {
            gm.MoveTopCard(deck2, deck3); // On déplace la carte du deck 2 sur le deck 3
            gm.MoveTopCard(deck1, deck3); // Puis on déplace la carte de deck 1 sur le deck 3
        }
        else // sinon 
        {
            gm.MoveTopCard(deck1, deck3); // On déplace la carte de deck 1 sur le deck 3
            gm.MoveTopCard(deck2, deck3); // puis on déplace la carte du deck 2 sur le deck 3
        }
    }

    public void exerciceA8()
    {
        gm.InitDeck(deck1, "T+K+C+P");

        if (gm.topCardColor(deck1) == CardColor.Karreau) // si la couleur de la carte du sommet du deck 1 est Karreau 
        {
            gm.MoveTopCard(deck1, deck2); // On déplace deck1 vers deck 2
        }
        else if (gm.topCardColor(deck1) == CardColor.Coeur) //sinon si 
        {
            gm.MoveTopCard(deck1, deck3);
        }
        else if (gm.topCardColor(deck1) == CardColor.Pique)
        {
            gm.MoveTopCard(deck1, deck4);
        }
    }

    public void exerciceA8Bis()
    {
        gm.InitDeck(deck1, "T+K+C+P");
        if (gm.topCardColor(deck1) == CardColor.Karreau)
        {
            gm.MoveTopCard(deck1, deck2);
        }

        if (!gm.DeckIsEmpty(deck1) && gm.topCardColor(deck1) == CardColor.Coeur)
        {
            gm.MoveTopCard(deck1, deck3);
        }

        if (!gm.DeckIsEmpty(deck1) && gm.topCardColor(deck1) == CardColor.Pique)
        {
            gm.MoveTopCard(deck1, deck4);
        }
    }

    public void exerciceA9()
    {
        gm.InitDeck(deck1, "(T+K+C+P)(T+K+C+P)");

        if (gm.topCardColor(deck1) == CardColor.Coeur || gm.topCardColor(deck1) == CardColor.Karreau)
        {
            gm.MoveTopCard(deck1, deck3);


            if (gm.topCardColor(deck1) == CardColor.Coeur || gm.topCardColor(deck1) == CardColor.Karreau)
            {
                gm.MoveTopCard(deck3, deck1);
            }
            else
            {
                gm.MoveTopCard(deck1, deck2);
                gm.MoveTopCard(deck3, deck1);
            }
        }
        else
        {
            gm.MoveTopCard(deck1, deck2);
            if (gm.topCardColor(deck1) == CardColor.Pique || gm.topCardColor(deck1) == CardColor.Treffle)
            {
                gm.MoveTopCard(deck1, deck2);
            }
        }
    }

    public void exerciceA9Bis()
    {
        gm.InitDeck(deck1, "(T+K+C+P)(T+K+C+P)");

        if (gm.topCardColor(deck1) == CardColor.Coeur || gm.topCardColor(deck1) == CardColor.Karreau) // si K ou C sur Deck1
        {
            gm.MoveTopCard(deck1, deck3); // On deplace deck1 vers deck3
        }
        else // sinon
        {
            gm.MoveTopCard(deck1, deck2); // On deplace deck1 vers deck2 
        }

        if (gm.topCardColor(deck1) == CardColor.Pique || gm.topCardColor(deck1) == CardColor.Treffle) // Si P ou T sur Deck 1 (on teste la deuxieme carte)
        {
            gm.MoveTopCard(deck1, deck2); // On deplace deck 1 vers deck 2 
        }

        if (!gm.DeckIsEmpty(deck3)) // Si on a une carte sur le deck 3
        {
            gm.MoveTopCard(deck3, deck1); // On deplace deck 3 vers deck 1
        }
    }

    private void exerciceA10()
    {
        gm.InitDeck(deck1, "[T]");
        ViderDeck(deck1, deck2);
    }

    private void exerciceA11()
    {
        gm.InitDeck(deck1, "[K+C][T+P]");

        // deplacer tous les T et P sur le Deck 2
        while (!gm.DeckIsEmpty(deck1) && (gm.topCardColor(deck1) == CardColor.Treffle || gm.topCardColor(deck1) == CardColor.Pique))
        {
            gm.MoveTopCard(deck1, deck2);
        }

        // "[K+C]" "[T+P]" "" ""
        ViderDeck(deck1, deck3);

        // "" "[T+P]" "[K+C]" ""
        ViderDeck(deck2, deck1);

        // "[T+P]" "" "[K+C]" ""
        ViderDeck(deck3, deck1);

        //"[T+P][K+C]" "" "" ""
    }


    private void Start()
    {
        gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        exerciceA11();

        // **********************************************
        // **********************************************
        // **********************************************
        gm.StartAnimation();
    }

}