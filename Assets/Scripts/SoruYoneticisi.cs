using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoruYoneticisi : MonoBehaviour
{
    public List<SorularveCevaplar> SvC;
    public GameObject[] options;
    public int MevcutSoru;

    public GameObject SoruPaneli;
    public GameObject OBPanel;

    public Text SoruMetni;
    public Text SkorMetni;

    int ToplamSoru = 0;
    public int skor;

    private void Basla()
    {
        ToplamSoru = SvC.Count;
        OBPanel.SetActive(false);
        SoruYarat();
    }

    public void TekrarDene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OyunBitti()
    {
        SoruPaneli.SetActive(false);
        OBPanel.SetActive(true);
        SkorMetni.text = skor + "/5";
    }

    public void dogru()
    {
        //doðru cevap verdiðinde
        skor += 1;
        SvC.RemoveAt(MevcutSoru);
        StartCoroutine(waitForNext());
    }

    public void yanlis()
    {
        //yanlýþ cevap verdiðinde
        SvC.RemoveAt(MevcutSoru);
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        SoruYarat();
    }

    void CevapVer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<ScriptCevaplar>().baslatRenk;
            options[i].GetComponent<ScriptCevaplar>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Image>().sprite = SvC[MevcutSoru].Cevaplar[i];


            if (SvC[MevcutSoru].DogruCevap == i + 1)
            {
                options[i].GetComponent<ScriptCevaplar>().isCorrect = true;
            }
        }
    }

    void SoruYarat()
    {
        if (SvC.Count > 0)
        {
            MevcutSoru = Random.Range(0, SvC.Count);

            SoruMetni.text = SvC[MevcutSoru].Soru;
            CevapVer();
        }
        else
        {
            Debug.Log("Sorular Bitti");
            OyunBitti();
        }


    }
}
