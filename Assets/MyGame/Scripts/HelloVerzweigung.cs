using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{

    int i = 2;
    void Start()
    {
        if(1==1)
        {
            Debug.Log("If Statement");
        }


        if (1==0)
        {
            Debug.Log("1=0");

        }
        else
        {
            Debug.Log("1 ist nicht 0");
        }

        if(1<2)
        {
            if(2<4)
            {
                Debug.Log("if in einem if statement");
            }
        }


        if (1==2)
        { Debug.Log("1 ist 2");
        
        }

        else if(1<2)
        {
            Debug.Log("1<2");
        }


        switch(i)
        {
            case 0: Debug.Log("case " + i);
                break;

            case 1:
                Debug.Log("case " + i);
                break;

            case 2:
                Debug.Log("case " + i);
                break;
        }
    }

   
}
