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

    public void viderCouleur(Deck from, Deck to, CardColor color)
    {
        while (!gm.DeckIsEmpty(from) && gm.topCardColor(from) == color)
        {
            gm.MoveTopCard(from, to);
        }
    }

    public void ViderDeck(Deck from, Deck to)
    {
        while (!gm.DeckIsEmpty(from))
        {
            gm.MoveTopCard(from, to);
        }
    }

    public void trouverPlusPetit(Deck depart, Deck deckPlusPetit, Deck reste)
    {
        if (!gm.DeckIsEmpty(depart))
        {
            gm.MoveTopCard(depart, deckPlusPetit);
        }

        while (!gm.DeckIsEmpty(depart))
        {
            if (gm.Superior(depart, deckPlusPetit))
            {
                gm.MoveTopCard(depart, reste);
            }
            else
            {
                gm.MoveTopCard(deckPlusPetit, reste);
                gm.MoveTopCard(depart, deckPlusPetit);
            }
        }
    }

    public void trierDeckPlusPetitAuPlusGrand(Deck depart, Deck Arrivée, Deck Transitoire)
    {
        while (!gm.DeckIsEmpty(depart))
        {
            trouverPlusPetit(depart, Arrivée, Transitoire);
            trouverPlusPetit(Transitoire, Arrivée, depart);
        }
    }

    public void exerciceTest()
    {
        gm.InitDeck(deck1, "TTTCCC");
        viderCouleur(deck1, deck3, CardColor.Coeur);
        viderCouleur(deck1, deck2, CardColor.Treffle);
    }

    public void exercice2()
    {
        gm.InitDeck(deck1, "TTTTTT");
        ViderDeck(deck1, deck2);
        trierDeckPlusPetitAuPlusGrand(deck2, deck1, deck3);

    }

    public int fibonacci(int n)
    {
        int resultat = 0;
        Debug.Log("appel " + n);

        if (n == 0)
        {
            resultat = 0;
        }
        else if (n == 1)
        {
            resultat = 1;
        }
        else
        {
            resultat = fibonacci(n - 1) + fibonacci(n - 2);
        }

        return resultat;
    }

    public int fibonacciIntelligent(int n , int[] results)
    {
        if(results[n] == -1)
        {
            Debug.Log("appel " + n);

            if (n == 0)
            {
                results[0] = 0;
            }
            else if (n == 1)
            {
                results[1] = 1;
            }
            else
            {
                results[n] = fibonacciIntelligent(n - 1, results) + fibonacciIntelligent(n - 2, results);
            }
        }

        return results[n];
    }

    public int fibonacciIntelligent(int n)
    {
        int[] results = new int[n+1];

        for (int i = 0; i < n+1 ; i++)
        {
            results[i] = -1;
        }

        return fibonacciIntelligent(n, results);
    }


    public int[] exerciceC1(int a, int b, int n)
    {
        int[] results = new int[n];
        for (int i = 0; i < n; i++)
        {
            results[i] = Random.Range(a, b);
        }
        return results;
    }

    public void exerciceC2(int[] numbers)
    {
        string toPrint = "";

        for (int i = 0; i < numbers.Length; i++)
        {
            toPrint = toPrint + "element à l'indice " + i + " est " + numbers[i] + "\n";
        }

        Debug.Log(toPrint);
    }

    public bool estPair(int i)
    {
        // 0 2 4 6
        // modulo => %
        // 0 mod 2 => 0
        // 1 mod 2 => 1
        // 2 mod 2 => 0 
        // 3 mod 2 => 1 
        // L’opérateur restant % calcule le reste après la division de son opérande de partie gauche par son opérande de partie droite.
        return i % 2 == 0;
    }


    public bool estImpair(int i)
    {
        // return i % 2 == 1;
        return !estPair(i);
    }

    public void exerciceC3(int[] numbers)
    {
        int inPairNumber = 0;
        int pairNumber = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if(estImpair(numbers[i]))
            {
                //inPairNumber = inPairNumber +1;
                //inPairNumber += 1;
                inPairNumber++;
            }
            else
            {
                pairNumber++;
            }
        }

        Debug.Log("Le nombre d'impair dans le tableau est " + inPairNumber);
        Debug.Log("Le nombre de pair dans le tableau est " + pairNumber);    
    }


    public float exerciceC4(int[] numbers)
    {
        int sommme = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sommme += numbers[i];
        }

        float moy = (float) sommme / numbers.Length;

        Debug.Log("La moy est " + moy);

        return moy;
    }


    private void Start()
    {
        gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        int[] randomNumbers = exerciceC1(0, 101, 10);
        //exerciceC2(randomNumbers);
        exerciceC4(randomNumbers);

        //exercice2();

        //fibonacciResults.insert(0,1);
        //fibonacciResults.Add(1);
        //fibonacciResults.Add(1);
        //fibonacciResults.Add(2);

        /*Debug.Log(fibonacciResults[0]);
        Debug.Log(fibonacciResults[1]);
        Debug.Log(fibonacciResults[2]);
        Debug.Log(fibonacciResults[3]);
        Debug.Log(fibonacciResults[4]);
        */

        //Debug.Log(fibonacci(3));
        //fibonacciIntelligent(5);

        //Suite de fibonacci
        // Un+1 = Un + Un-1
        // U0 = 0 U1 = 1

        // U2 = U1 + U0 = 1 + 0 = 1
        // U3 = U2 + U1 = 1 + 1 = 2
        // U4 = 3
        // U5 = 5
        // U6 = 8
        // U7 = 13
        // ....

        // impératif (suite d'instruction dans une fonction)
        // recursif (appel de la fonction dans la fonction)

        // **********************************************
        // **********************************************
        // **********************************************
        gm.StartAnimation();
    }

}