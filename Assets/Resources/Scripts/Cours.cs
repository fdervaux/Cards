using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cours : MonoBehaviour
{


    public int U(int n)
    {
        int res = 1; // U0

        for(int i = 1 ; i < n+1 ; i++)
        {
            res = res + 2;
        }

        return res;
    }


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


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");


        // UU0 = 1, UUn = 5 + (UUn-2 * 3)

        // fibonacci
        // F0 = 0 , F1 = 1, Fn = Fn-1 + Fn-2





        // U0=1  =>  U(n) = U(n-1) + 2
        // Un => 1 + n*2;

        // U0 = 1 => OK
        // U1 = U0 + 2 = (1+2) = 3
        // U2 = U1 + 2 = ((1+2)+2) = 5
        // U3 = U2 + 2 = (((1+2)+2)+2) = 7
        // ....

        
  


        for (int i = 0; i <= 15; i++)
        {
            Debug.Log("U("+ i +") = " + U(i));
            Debug.Log("V("+ i +") = " + V(i));
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
