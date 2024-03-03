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
        print("Benimle Oyun Oynamak Ýstermisin (E/H)");
        
    }

   
    void Update()
    {
        if (!OyunBasladi)
        {
            if(Input.GetKeyDown(KeyCode.E)) {
                print("Harika! Aklýndan 1-100 arasýnda bir sayi tut ve Enter tusuna bas");
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
                print("Yaþasýn,aklindaki sayiyi buldum !");
            }
        }
    }

    void Control()
    {
        Tahmin = (MinSayi + MaxSayi) / 2;
        print("Aklindan Tuttugun Sayi" + Tahmin + "mi? Daha Büyük ise Yukarý,daha küçük ise aþaðý yön tusuna bas! Dogruysa Bosluk tusuna bas!");
    }
}
