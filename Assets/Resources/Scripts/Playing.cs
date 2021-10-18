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

        if(gm.topCardColor(deck1) == CardColor.Treffle)
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

            if (gm.topCardColor(deck1) == CardColor.Pique || gm.topCardColor(deck1) == CardColor.Treffle)
            {
                gm.MoveTopCard(deck1, deck2);
            }
            gm.MoveTopCard(deck2, deck1);

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



    //Version de l'exercice 9 sans utiliser le else (version pour ceux qui sont curieux)
    //C'est un exercice compliqué. Les versions basique ou un peu factorisé sont déjà très bien ;) 
    private void MoveCardOnGoodDeckWithCondition(bool condition,Deck from, Deck firstTo, Deck secondTo)
    {
        if(condition)
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





    // fonction start (on cherche à garder cette fonction la plus simple possible, 
    // ici simplement un appel à la fonction correspondant à l'exercice en cours)
    private void Start() {

        gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        exerciceA9Ter();

        // **********************************************
        // **********************************************
        // **********************************************
        gm.StartAnimation();
    }

}