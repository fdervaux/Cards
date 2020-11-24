﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cours : MonoBehaviour
{
    public int U(int n)
    {
        int res = 1; // U0

        for (int i = 1; i < n + 1; i++)
        {
            res = res + 2;
        }

        return res;
    }
    
    public int URecursif(int n)
    {
        int res = 0;

        if(n!=0)
        {
            res = URecursif(n - 1) + 2;
        }

        return res;
    }

    // start Ur(6)
        // start Ur(5)
            // start Ur(4)
                // start Ur(3)
                    // start Ur(2)
                        // start Ur(1)
                            // start Ur(0)
                            // -> Ur(0) =0
                        // -> UR(1) = U(0)+2 = 2
                    // ->  UR(2) = U(1)+2 = 4
                // ->  UR(3) = U(2)+2 = 6
            // ->  UR(4) = U(3)+2 = 8
        // ->  UR(5) = U(4)+2 = 10
    // ->  UR(6) = U(5)+2 = 12


    // V0 = 4
    // Vn = Vn-1 * 3 
    public int V(int n)
    {
        int res = 4;

        for (int i = 1; i < n + 1; i++)
        {
            res = res * 3;
        }

        return res;
    }

    public int Vr(int n)
    {
        int res = 4;

        if(n != 0)
        {
            res = Vr(n - 1) * 3;
        }

        return res;
    }


    // UU0 = 1, UUn = 5 + (UUn-1 * 3)
    public int UU(int n)
    {
        int res = 1; // UU0

        for (int i = 1; i < n + 1; i++)
        {
            res = res * 3 + 5;
        }

        return res;
    }

    public int UUr(int n)
    {
        int res = 1;

        if( n!=0)
        {
            res = 5 + UUr(n - 1) * 3;
        }

        return res;
    }


    public int Fibonnacci(int n)
    {
        int resMoins1 = 0; // F0
        Debug.Log("fibonacci " + 0);
        
        int res = 1; // F1
        Debug.Log("fibonacci " + 1);

        for (int i = 2; i < n + 1; i++)
        {
            Debug.Log("fibonacci " + i);
            int tmp = res; // je stocke la valeur de Un-1
            res = res + resMoins1; // Je calcule la valeur de Un
            resMoins1 = tmp; 
        }

        if (n == 0)
            return resMoins1;
        else
            return res;
    }


    public int FibonnacciR(int n)
    {
        Debug.Log("fibonacciR " + n);

        int res = 0;
        
        if( n < 2)
            res = n;
        else
            res = FibonnacciR(n - 2) + FibonnacciR(n - 1);

        return res;
    }

    public (int ,int) FibonnacciRIntelligent(int n)
    {
        Debug.Log("fibonacciR " + n);

        (int,int) res = (0,0);

        if (n == 0)
        {
            res = (0, 0);
        }
        else if (n==1)
        {
            res = (1, 0);
        }
        else
        {
            (int resNmoins1, int resNMoins2) tmp = FibonnacciRIntelligent(n - 1);
            res = (tmp.resNmoins1 + tmp.resNMoins2, tmp.resNmoins1);
        }

        return res;
    }

    public int fibo(int n)
    {
        return FibonnacciRIntelligent(n).Item1;
    }

    public void printArray(int[] array)
    {
        string stringToPrint = "";

        for (int i = 0; i < array.Length - 1; i++)
        {
            stringToPrint += array[i] + ",";
        }

        if(array.Length > 0)
            stringToPrint += array[array.Length - 1];

        Debug.Log(stringToPrint);
    }


    private int[] generateRandomArray(int length, int min, int max)
    {
        //1 on crée le tableau
        int[] array = new int[length];

        //2 on met des valeurs random
        for (int i = 0; i < length; i++)
        {
            array[i] = Random.Range(min, max);
        }

        return array;
    }

    private int maxValueInArray(int[] array)
    {
        int noteMax = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if( array[i] > noteMax)
                noteMax = array[i];
        }

        return noteMax; 
    }

    private int minValueInArray(int[] array)
    {
        int noteMin = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < noteMin)
                noteMin = array[i];
        }

        return noteMin;
    }


    // est-ce que le tableaux contient la valeur "value" 
    // si oui -> true
    // si non -> false
    private bool contains(int[] array, int value)
    {
        bool isContained = false;

        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == value)
                isContained = true;
        }

        return isContained;
    }

    // l'indice du dernier element du tableau
    // si le tableaux contient value 
    //   -> l'indice de la dernière occurence de value
    // sinon -1
    private int lastOccurenceIndice(int[] array, int value)
    {
        int occurence = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
                occurence = i;
        }

        return occurence;
    }

    // l'indice du dernier element du tableau
    // si le tableaux contient value 
    //   -> l'indice de la première occurence de value
    // sinon -1
    private int firstOccurenceIndice(int[] array, int value)
    {
        int occurence = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                occurence = i;
                break;
            }
                
        }

        return occurence;
    }

    // l'indice du dernier element du tableau
    // le nombre d'ocurrence de value dans le tableau.
    private int numberOfOccurence(int[] array, int value)
    {

        int numberOfOccurence = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
                numberOfOccurence++;
        }

        return numberOfOccurence;
    }

    // renvoie le tableau d'indice de toute les occurences 
    private int[] arrayOfOccurenceIndice(int[] array, int value)
    {
        int length = numberOfOccurence(array, value); // parcour tout mon tableau
        int[] tableauIndice = new int[length];

        int cpt = 0;

        for (int i = 0; i < array.Length; i++) // pacour tout mon tableau
        {
            if (array[i] == value)
            {
                tableauIndice[cpt] = i;
                cpt++;
            }
                
        }

        return tableauIndice;
    }



    private int[] arrayOfOccurenceIndiceOneLoop(int[] array, int value)
    {
        int[] tableauIndice = new int[0];

        int cpt = 0;

        for (int i = 0; i < array.Length; i++) // pacour tout mon tableau
        {
            if (array[i] == value)
            {
                tableauIndice[cpt] = i;
                cpt++;
            }

        }

        return tableauIndice;
    }
    


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
        // fibonacci
        // F0 = 0 , F1 = 1, Fn = Fn-1 + Fn-2
        // U0=1  =>  U(n) = U(n-1) + 2
        // Un => 1 + n*2;
        // U0 = 1 => OK
        // U1 = U0 + 2 = (1+2) = 3
        // U2 = U1 + 2 = ((1+2)+2) = 5
        // U3 = U2 + 2 = (((1+2)+2)+2) = 7
        // ....

        //Fibonnacci(15); // complicxité 15
        //FibonnacciR(15);

        //fibo(15);

        for (int i = 0; i <= 15; i++)
        {
            //Debug.Log("U(" + i + ") = " + U(i));
            //Debug.Log("V(" + i + ") = " + V(i));
            //Debug.Log("UU(" + i + ") = " + UU(i));
            //Debug.Log("Fibonnacci(" + i + ") = " + Fibonnacci(i));
            //Debug.Log("Fr(" + i + ") = " + FibonnacciR(i));
        }

        int[] notes = generateRandomArray(30, 0, 20);
        printArray(notes);
        Debug.Log("maxValue : " + maxValueInArray(notes));

        Debug.Log("contains value :" + contains(notes, 10));

        int[] indices = arrayOfOccurenceIndice(notes, 10);

        printArray(indices);

        int res = Random.Range(0, 10);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
