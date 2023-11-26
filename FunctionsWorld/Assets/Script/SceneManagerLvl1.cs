using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerLvl1 : MonoBehaviour
{
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public GameObject part5;


    public TMP_InputField part2Input;
    public TMP_Text part2Text;
    public GameObject part2DevamBtn;
    public GameObject part2DeneBtn;


    public TMP_InputField part4Input;
    public TMP_InputField part4Input2;
    public TMP_Text part4Text;
    public GameObject part4DevamBtn;
    public GameObject part4DeneBtn;



    public void Part1To2()
    {
        part1.SetActive(false);
        part2.SetActive(true);
    }
    public void Part2To3()
    {
        part2.SetActive(false);
        part3.SetActive(true);
    }
    public void Part3To4()
    {
        part3.SetActive(false);
        part4.SetActive(true);
    }
    public void Part4To5()
    {
        part4.SetActive(false);
        part5.SetActive(true);
    }
    public void ReturnTheMenu() => SceneManager.LoadScene("Giris");

    public void Part2QuestionCheck()
    {
        part2Text.text = "Titana dönüşebilmem için yukardaki kodun çalışabilmesi lazım. Gerekli düzenlemeleri yapabilir misin lütfen.";

        part2DevamBtn.SetActive(false);
        part2DeneBtn.SetActive(true);

        if (part2Input.text != "yaz")
        {
            part2Text.text = "Yazdığın yanıt doğru değil.Tekrar düşünmekte fayda var.";
        }
        else
        {
            part2Text.text = "Doğru yanıt verdin. Diğer aktiviteye geçebilirsin.";
            part2DevamBtn.SetActive(true);
            part2DeneBtn.SetActive(false);

        }
    }

    public void Part4QuestionCheck()
    {
        part4Text.text = "Titan formunda uzun süre kalamaz. Bizimde Zırhlı Titana saldırmamız lazım. ";

        part4DevamBtn.SetActive(false);
        part4DeneBtn.SetActive(true);

        if (part4Input.text != "a,b" && part4Input2.text != "return")
        {
            part4Text.text = "Yazdığın yanıtlar doğru değil.Tekrar düşünmekte fayda var.";
        }

        else if (part4Input.text != "a,b" )
        {
            part4Text.text = "Yazdığın fonksiyon parametresindeki yanıtın doğru değil.Tekrar düşünmekte fayda var.";
        }
        else if (part4Input2.text != "return")
        {
            part4Text.text = "Yazdığın fonksiyonun en son işlemindeki yanıtın doğru değil.Tekrar düşünmekte fayda var.";
        }
        else
        {
            part4Text.text = "Doğru yanıt verdin. Diğer aktiviteye geçebilirsin.s";
            part4DevamBtn.SetActive(true);
            part4DeneBtn.SetActive(false);

        }
    }
}
