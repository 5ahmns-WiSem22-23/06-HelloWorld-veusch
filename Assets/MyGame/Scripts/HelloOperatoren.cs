
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloOperatoren : MonoBehaviour
{
    int i = 1;
    int s = 2;
    bool wahr = true;
    bool falsch = false;
    public Text displayInti;
    public Text displayInts;

    //Arithmetische Operatoren
    public void Plus()
    {
        i++;
        Debug.Log(i);
    }
    public void Minus()
    {
        i--;
        Debug.Log(i);
    }

    public void Addieren()
    {
        
        Debug.Log(i + s);
    }

    //Logische Operatoren(&,|,^) & Gleichheitsoperatoren (== !=)
    public void Und()
    {
        if(wahr==true&falsch==false)
        {
            Debug.Log("Und-Operator");
        }
    }

    public void Oder()
    {
        if (wahr == true | falsch == false)
        {
            Debug.Log("Oder-Operator");
        }
    }

    private void Update()
    {
        displayInti.text = i.ToString();
        displayInts.text = s.ToString();

        //Vergleichsoperatoren

        if(2==2)
        {
            Debug.Log("2 ist 2");
        }

        if(2!=0)
        {
            Debug.Log("2 ist nicht 0");
        }

        if(2<3)
        {

            Debug.Log("2 ist kleiner 3");
        }

       
    }
}
