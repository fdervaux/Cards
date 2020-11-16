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

    public int fibonacciIntelligent(int n, int[] results)
    {
        if (results[n] == -1)
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
        int[] results = new int[n + 1];

        for (int i = 0; i < n + 1; i++)
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
            if (estImpair(numbers[i]))
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

        float moy = (float)sommme / numbers.Length;

        Debug.Log("La moy est " + moy);

        return moy;
    }

    public int[] tri(int[] numbers)
    {
        int[] numbersTrie = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            int minimum = numbers[0];
            int indiceMinimum = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] < minimum)
                {
                    minimum = numbers[j];
                    indiceMinimum = j;
                }
            }

            numbersTrie[i] = minimum;
            numbers[indiceMinimum] = 1000;
        }

        return numbersTrie;

    }

    public void exerciceC5(ref int[] numbers)
    {
        exerciceC2(numbers);

        // randomNumbers => tableau de l'exerciceC1

        numbers = tri(numbers);

        // tableau de l'exercice C1 remplie de 1000
        // randomNumbers => tableau trié;

        exerciceC2(numbers);

        if (numbers.Length > 0)
        {
            int maximum = numbers[0];
            int minimum = numbers[0];
            int sommme = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }

                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }

                sommme += numbers[i];
            }

            float moy = (float)sommme / numbers.Length;
            float mediane = 0;

            if (numbers.Length % 2 == 0)
            {
                int indice1 = numbers.Length / 2;
                int indice2 = indice1 - 1;
                mediane = (float)(numbers[indice1] + numbers[indice2]) / 2.0f;
                // 0 => 1
                // 1 => 6
                // 2 => 8 = indice2
                // 3 => 5 = indice1
                // 4 => 6
                // 5 => 5
            }
            else
            {
                int indice = numbers.Length / 2; // => 3.5 mais division entière donc 3 
                mediane = numbers[indice];
                // 0 => 1
                // 1 => 6
                // 2 => 8 = indice2
                // 3 => 5 = indice1
                // 4 => 6
                // 5 => 5
                // 6 => 12
            }

            Debug.Log("maximum : " + maximum);
            Debug.Log("minimum : " + minimum);
            Debug.Log("moyenne : " + moy);
            Debug.Log("mediane : " + mediane);
        }
    }

    private void Start()
    {
        gm = GameManager.Instance();

        // **********************************************
        // *********** !!! Your code here !!! ***********
        // **********************************************

        int[] randomNumbers = exerciceC1(0, 21, 18);

        // randomNumbers => tableau de l'exerciceC1; 


        exerciceC5(ref randomNumbers);


        exerciceC2(randomNumbers);

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

    // 8 cases => horizontale
    // 8 cases => vertical

    // string[][] echiquier = new string[8][8];

    // "" "pion" "cavalier" "fou" "tour" "roi" "reine"
    // echiquier[0][0] = "tour";

    // initialiser l'échiquier.
    // afficher l'echiquier en console.

    // déplacements
    // - déplacement du pion (1 ou 2 case)
    // - déplacement du fou (direction) 
    // - déplacement du Tour (direction , nombre de case)
    // - déplacement du Roi (direction)
    // - Reine (direction , nombre de case)

    // - prise des pièces

    // liste des pieces prise par blanc

    //    A  B  C  D  E  F  G  H
    // 1 |BT|BC|BF|BR|Br|BF|BC|BT|
    // 2 |BP|BP|BP|BP|BP|BP|BP|BP|
    // 3 |  |  |  |  |  |  |  |  |
    // 4 |  |  |  |  |  |  |  |  |
    // 5 |  |  |  |  |  |  |  |  |
    // 6 |  |  |  |  |  |  |  |  |
    // 7 |NP|NP|NP|NP|NP|NP|NP|NP|
    // 8 |NT|NC|NF|Nr|NR|NF|NC|NT|

    // liste des pieces prise par Noir

}