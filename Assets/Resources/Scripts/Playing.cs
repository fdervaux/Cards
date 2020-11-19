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

    public void SecureMoveTopCard(Deck deckDepart, Deck deckDarriver)
    {
        if (DeckIsNotEmpty(deckDepart))
        {
            gm.MoveTopCard(deckDepart, deckDarriver);
        }
    }

    public void ViderCouleur(Deck deckDepart, Deck deckDArriver, CardColor couleur)
    {
        while (DeckIsNotEmpty(deckDepart) && gm.topCardColor(deckDepart) == couleur)
        {
            gm.MoveTopCard(deckDepart, deckDArriver);
        }
    }

    public void TrouverPlusPetit(Deck deckDepart, Deck DeckPlusPetit, Deck deckReste)
    {
        gm.MoveTopCard(deckDepart, DeckPlusPetit);

        while (DeckIsNotEmpty(deckDepart))
        {
            if (gm.Superior(deckDepart, DeckPlusPetit))
            {
                gm.MoveTopCard(deckDepart, deckReste);
            }
            else
            {
                gm.MoveTopCard(DeckPlusPetit, deckReste);
                gm.MoveTopCard(deckDepart, DeckPlusPetit);
            }
        }
    }

    public void TrouverPlusGrand(Deck deckDepart, Deck DeckPlusGrand, Deck deckReste, CardColor color)
    {
        gm.MoveTopCard(deckDepart, DeckPlusGrand);

        while (DeckIsNotEmpty(deckDepart) && gm.topCardColor(deckDepart) == color)
        {
            if (gm.Superior(deckDepart, DeckPlusGrand))
            {
                gm.MoveTopCard(DeckPlusGrand, deckReste);
                gm.MoveTopCard(deckDepart, DeckPlusGrand);
            }
            else
            {
                gm.MoveTopCard(deckDepart, deckReste);
            }
        }
    }

    private void diviserTasCouleur(Deck deckDepart, Deck DeckDarriver1, Deck DeckDarriver2, CardColor color)
    {
        while (DeckIsNotEmpty(deckDepart) && gm.topCardColor(deckDepart) == color)
        {
            gm.MoveTopCard(deckDepart, DeckDarriver1);

            if (DeckIsNotEmpty(deckDepart) && gm.topCardColor(deckDepart) == color)
                gm.MoveTopCard(deckDepart, DeckDarriver2);
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

        while (DeckIsNotEmpty(deck1) && DeckIsNotEmpty(deck2))
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

            /*
            if(DeckIsNotEmpty(deck1))
            {
                gm.MoveTopCard(deck1, deck3);
            }
            */
            SecureMoveTopCard(deck1, deck3);
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
        gm.InitDeck(deck1, "[T]");
        gm.InitDeck(deck2, "[K]");
        gm.InitDeck(deck3, "[C]");
        gm.InitDeck(deck4, "[P]");

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

    public void exerciceA16()
    {
        gm.InitDeck(deck1, "[T][K][C][P]");

        ViderCouleur(deck1, deck2, CardColor.Pique);
        ViderCouleur(deck1, deck3, CardColor.Coeur);
        ViderCouleur(deck1, deck4, CardColor.Karreau);
        ViderCouleur(deck1, deck3, CardColor.Treffle);
        ViderDeck(deck2, deck1);
        ViderCouleur(deck3, deck2, CardColor.Treffle);
        ViderDeck(deck3, deck1);
        ViderDeck(deck4, deck1);
        ViderDeck(deck2, deck1);
    }

    public void exerciceA17()
    {
        gm.InitDeck(deck1, "[T]");
        gm.InitDeck(deck2, "[K]");
        gm.InitDeck(deck3, "[P]");

        // Pseudo-code
        // Tant qu'un des trois tas n'est pas vide
        //      Si le deck1 n'est pas vide 
        //          deplacer une carte du deck1 sur deck4 
        //      Si le deck2 n'est pas vide
        //          deplacer une carte du deck2 sur deck4
        //      Si le deck3 n'est pas vide
        //          deplacer une carte du deck3 sur deck4

        while (DeckIsNotEmpty(deck1) || DeckIsNotEmpty(deck2) || DeckIsNotEmpty(deck3))
        {
            SecureMoveTopCard(deck1, deck4);
            SecureMoveTopCard(deck2, deck4);
            SecureMoveTopCard(deck3, deck4);
        }
    }

    public void exerciceA18()
    {
        gm.InitDeck(deck1, "[K+P+T+C]T[K+P+T+C]T[K+P+T+C]");

        // Tant que le deck1 n'est pas vide
        while (DeckIsNotEmpty(deck1))
        {
            // Si la carte du dessus du deck 1 est un carreau
            if (gm.topCardColor(deck1) == CardColor.Karreau)
            {
                // Si le deck2 n'est pas vide et que la carte du dessus est un Treffle
                if (DeckIsNotEmpty(deck2) && gm.topCardColor(deck2) == CardColor.Treffle)
                {
                    // On déplace tous les treffles sur le deck3
                    ViderCouleur(deck2, deck3, CardColor.Treffle);
                }

                // On déplace les carreau du deck1 sur le deck2
                ViderCouleur(deck1, deck2, CardColor.Karreau);
            }
            // Si la carte du dessus du deck 1 est un coeur
            else if (gm.topCardColor(deck1) == CardColor.Coeur)
            {
                // Si le deck3 n'est pas vide et que la carte du dessus est un Treffle
                if (DeckIsNotEmpty(deck3) && gm.topCardColor(deck3) == CardColor.Treffle)
                {
                    // On déplace tous les treffles sur le deck2
                    ViderCouleur(deck3, deck2, CardColor.Treffle);
                }
                // On déplace les coeur du deck1 sur le deck3
                ViderCouleur(deck1, deck3, CardColor.Coeur);
            }
            // Si la carte du dessus du deck 1 est un pique
            else if (gm.topCardColor(deck1) == CardColor.Pique)
            {
                // On déplace tous les pique sur le deck4
                ViderCouleur(deck1, deck4, CardColor.Pique);
            }
            // Si la carte du dessus du deck 1 est un treffle
            else if (gm.topCardColor(deck1) == CardColor.Treffle)
            {
                // Si le deck3 n'est pas vide et que la carte du dessus est un Treffle
                if ( DeckIsNotEmpty(deck3) && gm.topCardColor(deck3) == CardColor.Treffle)
                    //On déplace les treffles du deck 1 sur le deck3
                    ViderCouleur(deck1, deck3, CardColor.Treffle);
                else
                    //On déplace les treffles du deck 1 sur le deck2 
                    //(cas ou les treffles sont déjà sur le tas 2 ou il n'y à pas encore eu de treffle)
                    ViderCouleur(deck1, deck2, CardColor.Treffle);
            }
        }

        // Mouvement finale, on met les treffles sur le tas 1
        // Si les treffles sont sur le deck2
        if (DeckIsNotEmpty(deck2) && gm.topCardColor(deck2) == CardColor.Treffle)
            //On deplace les treffes sur le deck2 sur le deck1
            ViderCouleur(deck2, deck1, CardColor.Treffle);
        // sinon (c'est que le deck3 est vide ou qu'il contient des treffles)
        else
            // On deplace les treffes sur le deck3 sur le deck1
            // (Dans le cas ou il n'y a pas de treffle, la fonction ne fait rien ;) )
            ViderCouleur(deck3, deck1, CardColor.Treffle);
    }

    public void exerciceA18bis()
    {
        

        gm.InitDeck(deck1, "[K+P+T+C]T[K+P+T+C]T[K+P+T+C]");


        // L'idée ici est de remplacer le test fastidieux pour savoir
        // qu'elle est le deck qui contient les Treffles par l'utilisation d'une variable.
        // On va donc stocker en mémoire le tas ou sont les treffles.
        // Pour cela on crée une variable de type Deck que l'on nomme "deckOuSontLesTreffles".
        // Par défaut on initialise la variable à deck2 .
        // (Ce qui signifie que la première fois qu'on va bouger les treffles, nous allons arbitrairement choisir le deck2)
        Deck deckOuSontLesTreffles = deck2;

        while (DeckIsNotEmpty(deck1))
        {
            if (gm.topCardColor(deck1) == CardColor.Karreau)
            {

                // Au lieu de faire le test fastidieux nous regardons simplement si notre variable "deckOuSontLesTreffles" est égale au deck2 
                if (deckOuSontLesTreffles == deck2)
                {
                    ViderCouleur(deck2, deck3, CardColor.Treffle);
                    //On oublie pas de mettre à jour notre variable "deckOuSontLesTreffles" en affectant sa valeur avec "deck3"
                    deckOuSontLesTreffles = deck3;
                }
                ViderCouleur(deck1, deck2, CardColor.Karreau);
            }
            else if (gm.topCardColor(deck1) == CardColor.Coeur)
            {
                // Au lieu de faire le test fastidieux nous regardons simplement si notre variable "deckOuSontLesTreffles" est égale au deck3
                if (deckOuSontLesTreffles == deck3)
                {
                    ViderCouleur(deck3, deck2, CardColor.Treffle);
                    //On oublie pas de mettre à jour notre variable "deckOuSontLesTreffles" en affectant sa valeur avec "deck2"
                    deckOuSontLesTreffles = deck2;
                }
                ViderCouleur(deck1, deck3, CardColor.Coeur);
            }
            else if (gm.topCardColor(deck1) == CardColor.Pique)
            {
                ViderCouleur(deck1, deck4, CardColor.Pique);
            }
            else if (gm.topCardColor(deck1) == CardColor.Treffle)
            {
                // Au lieu de tester pour savoir ou sont les treffles, 
                // on peut ici utiliser directement notre variable pour dire ou déplacer les treffles
                ViderCouleur(deck1, deckOuSontLesTreffles, CardColor.Treffle);
            }
        }

        // De même, Au lieu de tester pour savoir ou sont les treffles, 
        // On peut ici utiliser directement notre variable pour déplacer les treffles sur le deck1
        ViderCouleur(deckOuSontLesTreffles, deck1, CardColor.Treffle);
    }

    private void exercice19()
    {
        gm.InitDeck(deck1, "T[T]");

        TrouverPlusPetit(deck1, deck2, deck3);
    }


    private void TrierCroissantDeck(Deck deckDepart, Deck Transition1, Deck Transition2 , CardColor color)
    {
        while (DeckIsNotEmpty(deckDepart) && gm.topCardColor(deckDepart) == color )
        {
            TrouverPlusGrand(deckDepart, Transition1, Transition2, color);
            if (DeckIsNotEmpty(Transition2) && gm.topCardColor(Transition2) == color)
            {
                TrouverPlusGrand(Transition2, Transition1, deckDepart, color);
            }
        }
        ViderCouleur(Transition1, deckDepart, color);
    }

    private void exercice20()
    {
        gm.InitDeck(deck1, "[TTTT]");


        while(DeckIsNotEmpty(deck1))
        {
            TrouverPlusPetit(deck1, deck2, deck3);
            if( DeckIsNotEmpty(deck3))
            {
                TrouverPlusPetit(deck3, deck2, deck1);
            }
        }

        /*
        
        // "TTTTTT" "" "" ""
        TrouverPlusPetit(deck1, deck2, deck3);
        // "" "T(plusPetit)" "TTTTT" ""
        ViderDeck(deck3, deck1);
        // "TTTTT" "T(plusPetit)" "" ""
        TrouverPlusPetit(deck1, deck2, deck3);
        // "" "TT (les deux plus petit)" "TTTT" ""
        ViderDeck(deck3, deck1);
        // "TTTT" "TT(plusPetit)" "" ""
        
        */

    }
    
    private void exercice21()
    {
        gm.InitDeck(deck1, "TTTKKK"); // TTKTTKKKKK

        //  trier les cartes sur deux tas (treffle sur deck2 et karreau sur deck3)
        while (DeckIsNotEmpty(deck1))
        {
            if( gm.topCardColor(deck1) == CardColor.Treffle)
            {
                gm.MoveTopCard(deck1, deck2);
            }
            else if( gm.topCardColor(deck1) == CardColor.Karreau)
            {
                gm.MoveTopCard(deck1, deck3);
            }   
        }

        //On transfert les cartes sur les deck restant jusqu'à ce qu'un deck soit vide
        while (DeckIsNotEmpty(deck2) && DeckIsNotEmpty(deck3))
        {
            gm.MoveTopCard(deck2, deck1);
            gm.MoveTopCard(deck3, deck4);
        }

        //Si il y a encore des cartes sur le deck2, ca signifie que les treffles sont majoritaire ou qu'on à le meme nombre de carte
        if ( DeckIsNotEmpty(deck2) || (gm.DeckIsEmpty(deck2) && gm.DeckIsEmpty(deck3)))
        {
            ViderDeck(deck2, deck1);
            ViderDeck(deck4, deck1);
        }
        else // sinon c'est qu'il y a plus de Karreau
        {
            ViderDeck(deck1, deck2);
            ViderDeck(deck3, deck1);
            ViderDeck(deck4, deck1);
            ViderDeck(deck2, deck1);
        }
    }


    private void exercice21bis()
    {
        gm.InitDeck(deck1, "TTTKKK[T+K]"); // TTKTTKKKKK

        int nbKarreau = 0;
        int nbTreffle = 0;

        //  trier les cartes sur deux tas (treffle sur deck2 et karreau sur deck3)
        while (DeckIsNotEmpty(deck1))
        {
            if (gm.topCardColor(deck1) == CardColor.Treffle)
            {
                gm.MoveTopCard(deck1, deck2);
                // nbTreffle = nbTreffle + 1;
                // nbTreffle += 1;
                nbTreffle++;

            }
            else if (gm.topCardColor(deck1) == CardColor.Karreau)
            {
                gm.MoveTopCard(deck1, deck3);
                nbKarreau++;
            }
        }

        if(nbKarreau > nbTreffle)
        {
            ViderDeck(deck3, deck1);
            ViderDeck(deck2, deck1);
        }
        else
        {
            ViderDeck(deck2, deck1);
            ViderDeck(deck3, deck1);
        }
    }

    private void exercice22()
    {
        gm.InitDeck(deck1, "K[TTTT]");

        diviserTasCouleur(deck1, deck2, deck3, CardColor.Treffle);
        
        // On deplace le K
        gm.MoveTopCard(deck1, deck2);

        diviserTasCouleur(deck3, deck1, deck4, CardColor.Treffle);

        // On deplace le K
        gm.MoveTopCard(deck2, deck1);

        diviserTasCouleur(deck2, deck1, deck3, CardColor.Treffle);

        ViderCouleur(deck1, deck2, CardColor.Treffle);
    }


    private void exercice23()
    {
        gm.InitDeck(deck1, "[T]");
        gm.InitDeck(deck2, "[K]");
        gm.InitDeck(deck3, "[C]");
        gm.InitDeck(deck4, "[P]");

        TrierCroissantDeck(deck1, deck2, deck3, CardColor.Treffle);
        TrierCroissantDeck(deck2, deck4, deck3, CardColor.Karreau);
        TrierCroissantDeck(deck3, deck2, deck1, CardColor.Coeur);
        TrierCroissantDeck(deck4, deck2, deck3, CardColor.Pique);
    }

    private void Start()
    {
        gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        exercice23();

        // **********************************************
        // **********************************************
        // **********************************************
        gm.StartAnimation();
    }

}