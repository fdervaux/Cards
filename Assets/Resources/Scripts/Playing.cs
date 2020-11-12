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
    

    public bool DeckIsNotEmpty(Deck deck)
    {
        return !gm.DeckIsEmpty(deck);
    }

    public void ViderDeck(Deck deckDepart, Deck deckDArriver)
    {
        while (!gm.DeckIsEmpty(deckDepart))
        {
            gm.MoveTopCard(deckDepart, deckDArriver);
        }
    }

    public void ViderCouleur(Deck deckDepart, Deck deckDArriver, CardColor couleur)
    {
        while (DeckIsNotEmpty(deckDepart) && gm.topCardColor(deckDepart) == couleur)
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

    public void exerciceA12()
    {
        gm.InitDeck(deck1, "[K]");
        gm.InitDeck(deck2, "[T]");

        // SItuation finale "[K]" "" "[KT]" "" 
        //                  "" "[T]" "[KT]" ""

        // Pseudo-code:
        // ***************************
        // tant que deck1 n'est pas vide et deck2 n'est pas vide
        // deplacer carte de deck1 sur deck3 
        // puis deplacer carte deck2 sur deck3

        while (DeckIsNotEmpty(deck1) && DeckIsNotEmpty(deck2) )
        {
            gm.MoveTopCard(deck1, deck3);
            gm.MoveTopCard(deck2, deck3);
        }
    }

    public void exerciceA13()
    {
        // Pseudo-code:
        // *****************
        // tant que j'ai des cartes sur le deck1 
        //      Je déplace la carte du sommet du deck1 sur le deck2 "On vérifie avec la condition du while qu'il y a au moins une carte sur le deck" 
        //      Je déplace la carte du sommet du deck1 sur le deck3 => impossible si le deck1 est vide => Erreur "mais on ne vérifie pas qu'il y ai deux carte"

        // Le bonne algorithme:
        // tant que j'ai des cartes sur le deck1 
        //      Je déplace la carte du sommet du deck1 sur le deck2
        //      si le deck contient encore une carte
        //          Je déplace la carte du sommet du deck1 sur le deck3 

        gm.InitDeck(deck1, "[T]");

        while (DeckIsNotEmpty(deck1))
        {
            gm.MoveTopCard(deck1, deck2);

            if(DeckIsNotEmpty(deck1))
            {
                gm.MoveTopCard(deck1, deck3);
            }
        }
    }


    public void exerciceA14()
    {
        gm.InitDeck(deck1, "[T]");
        gm.InitDeck(deck2, "[K]");
        gm.InitDeck(deck3, "[P]");

        ViderDeck(deck3, deck4);
        ViderDeck(deck2, deck3);
        ViderDeck(deck1, deck2);
    }


    public void exerciceA15()
    {
        gm.InitDeck(deck1, "[T]T");
        gm.InitDeck(deck2, "[K]K");
        gm.InitDeck(deck3, "[C]C");
        gm.InitDeck(deck4, "[P]P");

        /*
            Situation finale :
            Deck 1 : "[P]"
            Deck 2 : "[T]"
            Deck 3 : "[K]"
            Deck 4 : "[C]"
        */

        ViderDeck(deck4, deck1);
        ViderDeck(deck3, deck4);
        // Deck 1 : "[T][P]" Deck 2 : "[K]" Deck 3 : "" Deck 4 : "[C]"
        ViderDeck(deck2, deck3);
        // Deck 1 : "[T][P]" Deck 2 : "" Deck 3 : "[K]" Deck 4 : "[C]"
        ViderCouleur(deck1, deck3, CardColor.Pique);
        // Deck 1 : "[T]" Deck 2 : "" Deck 3 : "[K][P]" Deck 4 : "[C]"
        ViderDeck(deck1, deck2);
        // Deck 1 : "" Deck 2 : "[T]" Deck 3 : "[K][P]" Deck 4 : "[C]"
        ViderCouleur(deck3, deck1, CardColor.Pique);
    }

    private void Start()
    {
        gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        exerciceA15();

        // **********************************************
        // **********************************************
        // **********************************************
        gm.StartAnimation();
    }

}