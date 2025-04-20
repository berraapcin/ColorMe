using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptCevaplar : MonoBehaviour
{
    public bool isCorrect = false;
    public SoruYoneticisi soruYoneticisi;

    public Color baslatRenk;
    public void Baslat()
    {
        baslatRenk = GetComponent<Image>().color = Color.yellow;
    }

    public void Cevaplar()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Do�ru Cevap");
            soruYoneticisi.dogru();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Yanl�� Cevap");
            soruYoneticisi.yanlis();
        }
    }
}
