using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gecisler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void mavi()
    {
        SceneManager.LoadScene("mavi_haftasi");
    }
    public void yesil()
    {
        SceneManager.LoadScene("yesil_haftasi");
    }
    public void mor()
    {
        SceneManager.LoadScene("mor_haftasi");
    }
    public void kirmizi()
    {
        SceneManager.LoadScene("kirmizi_haftasi");
    }
    public void turuncu()
    {
        SceneManager.LoadScene("turuncu_haftasi");
    }
    public void sari()
    {
        SceneManager.LoadScene("sari_haftasi");
    }
    public void pembe()
    {
        SceneManager.LoadScene("pembe_haftasi");
    }
    public void kahve()
    {
        SceneManager.LoadScene("kahverengi_haftasi");
    }
    public void siyah()
    {
        SceneManager.LoadScene("siyah_haftasi");
    }
}