using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Playing : MonoBehaviour
{
    public Deck deck1;
    public Deck deck2;
    public Deck deck3;
    public Deck deck4;

    public GameManager gm;


    //Exercice carte Basic
    private void exercice1()
    {
        gm.InitDeck(deck1, "T");
        gm.InitDeck(deck1, "T+P");
        gm.InitDeck(deck1, "T+P+K+C");
        gm.InitDeck(deck1, "CC");
        gm.InitDeck(deck1, "CK");
        gm.InitDeck(deck1, "[P]");
        gm.InitDeck(deck1, "[P]+[C]");
        gm.InitDeck(deck1, "[T+C+P+K]");
        gm.InitDeck(deck1, "[K]K");
        gm.InitDeck(deck1, "(T[C])+(P[P])");
        gm.InitDeck(deck1, "[CC]");
        gm.InitDeck(deck1, "C[CC]");
        gm.InitDeck(deck1, "[TT]+[PPP]");
        gm.InitDeck(deck1, "T[KC]T");
    }

    private void exerciceA2()
    {
        gm.InitDeck(deck1, "TT");

        gm.MoveTopCard(deck1, deck2);
        gm.MoveTopCard(deck1, deck2);
    }


    private void exerciceA3()
    {
        gm.InitDeck(deck1, "TK");
        gm.MoveTopCard(deck1, deck2);
        gm.MoveTopCard(deck1, deck3);
        gm.MoveTopCard(deck2, deck1);
        gm.MoveTopCard(deck3, deck1);
    }

    private void exerciceA4()
    {
        gm.InitDeck(deck1, "TKTK");
        gm.MoveTopCard(deck1, deck2);
        gm.MoveTopCard(deck1, deck3);
        gm.MoveTopCard(deck1, deck2);
        gm.MoveTopCard(deck1, deck3);

        gm.MoveTopCard(deck2, deck1);
        gm.MoveTopCard(deck2, deck1);

        gm.MoveTopCard(deck3, deck1);
        gm.MoveTopCard(deck3, deck1);
    }

    private void exerciceA5()
    {
        gm.InitDeck(deck1, "TKCP");
        gm.MoveTopCard(deck1, deck2);
        gm.MoveTopCard(deck1, deck3);
        gm.MoveTopCard(deck1, deck4);
        gm.MoveTopCard(deck1, deck4);
        gm.MoveTopCard(deck2, deck1);
        gm.MoveTopCard(deck3, deck1);
        gm.MoveTopCard(deck4, deck2);
        gm.MoveTopCard(deck4, deck1);
        gm.MoveTopCard(deck2, deck1);
    }


    //Exercice carte Conditionnelle

    private void exerciceA6()
    {
        gm.InitDeck(deck1, "T+P");

        if (gm.topCardColor(deck1) == CardColor.Treffle)
        {
            gm.MoveTopCard(deck1, deck2);
        }
        else
        {
            gm.MoveTopCard(deck1, deck3);
        }
    }

    private void exerciceA7()
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

    public void exerciceA8Ter()
    {
        gm.InitDeck(deck1, "T+K+C+P");
        if (gm.topCardColor(deck1) == CardColor.Karreau)
        {
            gm.MoveTopCard(deck1, deck2);
            return;
        }

        if (gm.topCardColor(deck1) == CardColor.Coeur)
        {
            gm.MoveTopCard(deck1, deck3);
            return;
        }

        if (gm.topCardColor(deck1) == CardColor.Pique)
        {
            gm.MoveTopCard(deck1, deck4);
            return;
        }
    }


    //Version basique de l'exercice 9
    public void exerciceA9()
    {
        gm.InitDeck(deck1, "(T+K+C+P)(T+K+C+P)");

        if (gm.topCardColor(deck1) == CardColor.Coeur || gm.topCardColor(deck1) == CardColor.Karreau)
        {
            gm.MoveTopCard(deck1, deck3);

            if (gm.topCardColor(deck1) == CardColor.Pique || gm.topCardColor(deck1) == CardColor.Treffle)
            {
                gm.MoveTopCard(deck1, deck2);
            }

            gm.MoveTopCard(deck1, deck3);

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



    // Version de l'exercice 9 avec une factorisation
    private void MovePOrTfromDeck1toDeck2()
    {
        if (gm.topCardColor(deck1) == CardColor.Pique || gm.topCardColor(deck1) == CardColor.Treffle)
        {
            gm.MoveTopCard(deck1, deck2);
        }
    }

    public void exerciceA9Bis()
    {
        gm.InitDeck(deck1, "(T+K+C+P)(T+K+C+P)");

        if (gm.topCardColor(deck1) == CardColor.Coeur || gm.topCardColor(deck1) == CardColor.Karreau)
        {
            gm.MoveTopCard(deck1, deck3);

            MovePOrTfromDeck1toDeck2();
            gm.MoveTopCard(deck2, deck1);

        }
        else
        {
            gm.MoveTopCard(deck1, deck2);
            MovePOrTfromDeck1toDeck2();
        }
    }


    //Version de l'exercice 9 sans utiliser le else (version pour ceux qui sont curieux)
    //C'est un exercice compliqué. Les versions basique ou un peu factorisé sont déjà très bien ;) 
    private void MoveCardOnGoodDeckWithCondition(bool condition, Deck from, Deck firstTo, Deck secondTo)
    {
        if (condition)
        {
            gm.MoveTopCard(from, firstTo);
            return;
        }

        gm.MoveTopCard(from, secondTo);
    }


    private void exerciceA9Ter()
    {
        // dans cette version on cherche à éviter le else
        // On ecrit donc une fonction générique qui nous permet de déplacer une carte en fonction d'une condition.


        gm.InitDeck(deck1, "(T+K+C+P)(T+K+C+P)");

        // Deplacer carte sur le bon deck, si c ou p , on déplace sur deck3, sinon sur le deck2
        MoveCardOnGoodDeckWithCondition(
            gm.topCardColor(deck1) == CardColor.Coeur || gm.topCardColor(deck1) == CardColor.Karreau,
            deck1,
            deck3,
            deck2
        );

        // Deplacer deuxieme carte sur le bon deck, si c ou p , on déplace sur deck1 (du coup on la laisse sur le meme deck), sinon sur le deck2
        MoveCardOnGoodDeckWithCondition(
            gm.topCardColor(deck1) == CardColor.Coeur || gm.topCardColor(deck1) == CardColor.Karreau,
            deck1,
            deck1,
            deck2
        );

        if (!gm.DeckIsEmpty(deck3)) // Si on a une carte sur le deck 3
        {
            gm.MoveTopCard(deck3, deck1); // On deplace deck 3 vers deck 1
        }

    }

    private void exerciceA10()
    {
        gm.InitDeck(deck1, "[T]");

        //Première version sans utiliser de fonction
        /*while(!gm.DeckIsEmpty(deck1))
        {
            gm.MoveTopCard(deck1,deck2);
        }*/


        //Utilisation de la fonction vider tas
        viderDeck(deck1, deck2);
    }

    private void viderDeck(Deck from, Deck to)
    {
        while (!gm.DeckIsEmpty(from))
        {
            gm.MoveTopCard(from, to);
        }
    }

    private void exerciceA11()
    {
        gm.InitDeck(deck1, "[K+C][T+P]");

        while (!gm.DeckIsEmpty(deck1) && (gm.topCardColor(deck1) == CardColor.Treffle || gm.topCardColor(deck1) == CardColor.Pique))
        {
            gm.MoveTopCard(deck1, deck2);
        }

        viderDeck(deck1, deck3);
        viderDeck(deck2, deck1);
        viderDeck(deck3, deck1);
    }

    private void exercice11Simple()
    {
        gm.InitDeck(deck1, "[K][T]");

        while (!gm.DeckIsEmpty(deck1) && gm.topCardColor(deck1) == CardColor.Treffle)
        {
            gm.MoveTopCard(deck1, deck2);
        }

        viderDeck(deck1, deck3);
        viderDeck(deck2, deck1);
        viderDeck(deck3, deck1);

        //Ancienne version sans fonction
        /*while(!gm.DeckIsEmpty(deck1))
        {
            gm.MoveTopCard(deck1,deck3);
        }
        while(!gm.DeckIsEmpty(deck2))
        {
            gm.MoveTopCard(deck2,deck1);
        }
        while(!gm.DeckIsEmpty(deck3))
        {
            gm.MoveTopCard(deck3,deck1);
        }*/
    }

    private void exerciceA12()
    {
        gm.InitDeck(deck1, "[K]");
        gm.InitDeck(deck2, "[T]");

        while (!gm.DeckIsEmpty(deck1) && !gm.DeckIsEmpty(deck2))
        {
            gm.MoveTopCard(deck1, deck3);
            gm.MoveTopCard(deck2, deck3);
        }
    }

    private void moveCardSafe(Deck from, Deck to)
    {
        if (!gm.DeckIsEmpty(from))
        {
            gm.MoveTopCard(from, to);
        }
    }

    private void exerciceA13()
    {
        gm.InitDeck(deck1, "[T]");

        while (!gm.DeckIsEmpty(deck1))
        {
            gm.MoveTopCard(deck1, deck2);

            moveCardSafe(deck1, deck3);
        }
    }

    private void viderCouleur(Deck deckFrom, Deck deckTo, CardColor color)
    {
        while (!gm.DeckIsEmpty(deckFrom) && gm.topCardColor(deckFrom) == color)
        {
            gm.MoveTopCard(deckFrom, deckTo);
        }
    }


    private void exerciceA14()
    {
        gm.InitDeck(deck1, "[T]");
        gm.InitDeck(deck2, "[K]");
        gm.InitDeck(deck3, "[P]");


        viderDeck(deck3, deck4);
        viderDeck(deck2, deck3);
        viderDeck(deck1, deck2);

        //Ancienne version sans fonction
        /*while(!gm.DeckIsEmpty(deck3))
        {
            gm.MoveTopCard(deck3,deck4);
        }

        while(!gm.DeckIsEmpty(deck2))
        {
            gm.MoveTopCard(deck2,deck3);
        }

        while(!gm.DeckIsEmpty(deck1))
        {
            gm.MoveTopCard(deck1,deck2);
        }*/
    }
    private void exerciceA15()
    {
        gm.InitDeck(deck1, "[T]");
        gm.InitDeck(deck2, "[K]");
        gm.InitDeck(deck3, "[C]");
        gm.InitDeck(deck4, "[P]");

        viderDeck(deck2, deck3);
        viderDeck(deck1, deck2);
        viderDeck(deck4, deck1);
        viderCouleur(deck3, deck2, CardColor.Karreau);
        viderDeck(deck3, deck4);
        viderCouleur(deck2, deck3, CardColor.Karreau);

    }

    private void exerciceA16()
    {
        gm.InitDeck(deck1, "[T][K][C][P]");

        viderCouleur(deck1, deck2, CardColor.Pique);
        viderCouleur(deck1, deck3, CardColor.Coeur);
        viderCouleur(deck1, deck4, CardColor.Karreau);

        viderDeck(deck1, deck2);

        viderDeck(deck4, deck1);
        viderDeck(deck3, deck1);

        viderCouleur(deck2, deck3, CardColor.Treffle);

        viderDeck(deck2, deck1);
        viderDeck(deck3, deck1);

        // version très simple de l'exercice ;)
        //viderDeck( deck1, deck2);
        //viderDeck( deck2, deck3);
        //viderDeck( deck3, deck1);
    }

    private void moveIfNotEmpty(Deck deckFrom, Deck deckTo)
    {
        if (!gm.DeckIsEmpty(deckFrom))
        {
            gm.MoveTopCard(deckFrom, deckTo);
        }
    }

    private void exerciceA17()
    {
        gm.InitDeck(deck1, "[T]");
        gm.InitDeck(deck2, "[K]");
        gm.InitDeck(deck3, "[P]");


        while (!gm.DeckIsEmpty(deck1) || !gm.DeckIsEmpty(deck2) || !gm.DeckIsEmpty(deck3))
        {
            moveIfNotEmpty(deck1, deck4);
            moveIfNotEmpty(deck2, deck4);
            moveIfNotEmpty(deck3, deck4);
        }

    }

    private void exerciceA18()
    {
        gm.InitDeck(deck1, "TTKKCCPPCCPPKKTT");

        while (!gm.DeckIsEmpty(deck1))
        {
            if (gm.topCardColor(deck1) == CardColor.Karreau)
            {
                viderCouleur(deck1, deck2, CardColor.Karreau);
            }
            else if (gm.topCardColor(deck1) == CardColor.Coeur)
            {
                gm.MoveTopCard(deck1, deck3);
            }
            else if (gm.topCardColor(deck1) == CardColor.Treffle)
            {
                gm.MoveTopCard(deck1, deck4);
            }
            else if (gm.topCardColor(deck1) == CardColor.Pique)
            {
                viderCouleur(deck4, deck3, CardColor.Treffle);
                gm.MoveTopCard(deck1, deck4);
                viderCouleur(deck3, deck4, CardColor.Treffle);
            }
        }

        viderCouleur(deck4, deck1, CardColor.Treffle);
    }

    //version optimale de l'exercice 18
    private void exerciceA18Optimal()
    {
        gm.InitDeck(deck1, "TTKKCCPPCCPPKKTT");

        while (!gm.DeckIsEmpty(deck1))
        {
            // il faut vérifier si c'est un pique pour déplacer les cartes treffles avant. 
            if (gm.topCardColor(deck1) == CardColor.Pique)
            {
                viderCouleur(deck4, deck3, CardColor.Treffle);
                viderCouleur(deck1, deck4, CardColor.Pique);
                viderCouleur(deck3, deck4, CardColor.Treffle);
            }
            else
            {
                // pas besoin de verifier s'il y a une carte ou si c'est un carreau, la fonction viderColuleur le fait déjà et ne fait rien sinon
                viderCouleur(deck1, deck2, CardColor.Karreau);

                // pas besoin de verifier s'il y a une carte ou si c'est un Coeur, la fonction viderColuleur le fait déjà et ne fait rien sinon
                viderCouleur(deck1, deck3, CardColor.Coeur);

                // pas besoin de verifier s'il y a une carte ou si c'est un Treffle, la fonction viderColuleur le fait déjà et ne fait rien sinon
                viderCouleur(deck1, deck4, CardColor.Treffle);
            }
        }

        viderCouleur(deck4, deck1, CardColor.Treffle);
    }


    private void exerciceA19()
    {

    }





    

    







    // fonction start (on cherche à garder cette fonction la plus simple possible, 
    // ici simplement un appel à la fonction correspondant à l'exercice en cours)
    private void Start()
    {

        gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        //exerciceA18Optimal();
        
        

        // **********************************************
        // **********************************************
        // **********************************************
        gm.StartAnimation();
    }

}