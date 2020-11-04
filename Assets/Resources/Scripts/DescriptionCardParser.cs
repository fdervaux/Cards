
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionCardParser
{
    public static string parse(string desc,int maxRandomCard)
    {
        List<string> cardsToAddDescriptions =  new List<string>();

        string currentCardToAddDescritption = "";
        int parentheseCount = 0;
        int squareCount = 0;

        for (var i = 0; i < desc.Length; i++)
        {
            if (desc[i] == '(')
            {
                parentheseCount++;
                var tmpDesc = "";
                i++;
                while (parentheseCount > 0 && i < desc.Length)
                {
                    if (desc[i] == '(') parentheseCount++;

                    if (desc[i] == ')') parentheseCount--;

                    if (parentheseCount != 0)
                    {
                        tmpDesc += desc[i];
                        i++;
                    }
                }
                currentCardToAddDescritption += parse(tmpDesc,maxRandomCard);
                continue;
            }
            else if (desc[i] == '[')
            {
                squareCount++;
                string tmpDesc = "";
                i++;
                while (squareCount > 0 && i < desc.Length)
                {
                    if (desc[i] == '[') squareCount++;

                    if (desc[i] == ']') squareCount--;

                    if (squareCount != 0)
                    {
                        tmpDesc += desc[i];
                        i++;
                    }
                }
                int repeatNumber = Random.Range(0, maxRandomCard+1);
                for (int j = 0; j < repeatNumber; j++)
                {
                    currentCardToAddDescritption += parse(tmpDesc,maxRandomCard);
                }
                continue;
            }
            else if (desc[i] == 'T' || desc[i] == 'K' || desc[i] == 'C' || desc[i] == 'P')
            {
                currentCardToAddDescritption += desc[i];
            }
            else if (desc[i] == '+')
            {
                cardsToAddDescriptions.Add(currentCardToAddDescritption);
                currentCardToAddDescritption = "";
            }
            else
            {
                throw new System.ArgumentException("Invalid Character: " + desc[i]);
            }
        }

        if (parentheseCount > 0 || squareCount > 0)
        {
            throw new System.ArgumentException("Invalid description (parentheses or bracket are not valid)");
        }

        cardsToAddDescriptions.Add(currentCardToAddDescritption);

        int index = Random.Range(0, cardsToAddDescriptions.Count);
        return cardsToAddDescriptions[index];

    }
}