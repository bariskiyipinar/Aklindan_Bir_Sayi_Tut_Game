using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    int MinSayi = 1;
    int MaxSayi = 100;
    int Tahmin;
    bool OyunBasladi=false;

    void Start()
    {
        print("Benimle Oyun Oynamak �stermisin (E/H)");
        
    }

   
    void Update()
    {
        if (!OyunBasladi)
        {
            if(Input.GetKeyDown(KeyCode.E)) {
                print("Harika! Akl�ndan 1-100 aras�nda bir sayi tut ve Enter tusuna bas");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Sen Bilirsin");
            }
            if(Input.GetKeyDown(KeyCode.Return)) {

                Control(); 
                OyunBasladi = true;
            }
        }
        else {
        if (Input.GetKeyDown (KeyCode.UpArrow)) {
                MinSayi = Tahmin;
                Control();
            }
            else if(Input.GetKeyDown(KeyCode.DownArrow)) { 
                MaxSayi = Tahmin;
                Control();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Ya�as�n,aklindaki sayiyi buldum !");
            }
        }
    }

    void Control()
    {
        Tahmin = (MinSayi + MaxSayi) / 2;
        print("Aklindan Tuttugun Sayi" + Tahmin + "mi? Daha B�y�k ise Yukar�,daha k���k ise a�a�� y�n tusuna bas! Dogruysa Bosluk tusuna bas!");
    }
}
