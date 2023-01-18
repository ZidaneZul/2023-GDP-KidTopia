using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Baby baby;
    public GameObject wShop;
    public GameObject wFood;
    public GameObject wHealth;
    public GameObject wToy;
    public GameObject wSpecials;
    public TextMeshProUGUI moneyTxt;
    public static int money;
    public static bool salaryDown;

    public GameObject wRandom;
    public GameObject wJob;

    private void Start()
    {
        money = 1000;
    }
    private void Update()
    {
        moneyTxt.text = "$" + money.ToString();
    }
    public void CloseWindow()
    {
        wShop.SetActive(false);
        wFood.SetActive(false);
        wHealth.SetActive(false);
        wToy.SetActive(false);
        wSpecials.SetActive(false);
        wRandom.SetActive(false);
        wJob.SetActive(false); 
    }
    public void work()
    {
        wJob.SetActive(true);
    }
    public void LeftButton()
    {
        wRandom.SetActive(false);
    }
    public void RightButton()
    {
        wRandom.SetActive(false);
    }
    public void Shop()
    {
        wShop.SetActive(true);
        CheckShop();
    }
    void CheckShop()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string btnName = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        if (btnName == "Food") 
        {
            wFood.SetActive(true);
            wHealth.SetActive(false);
            wToy.SetActive(false);
            wSpecials.SetActive(false);
        }
        else if (btnName == "Health")
        {
            wFood.SetActive(false);
            wHealth.SetActive(true);
            wToy.SetActive(false);
            wSpecials.SetActive(false);
        }
        else if (btnName == "Toy")
        {
            wFood.SetActive(false);
            wHealth.SetActive(false);
            wToy.SetActive(true);
            wSpecials.SetActive(false);
        }
        else if (btnName == "Specials")
        {
            wFood.SetActive(false);
            wHealth.SetActive(false);
            wToy.SetActive(false);
            wSpecials.SetActive(true);
        }
    }
    void hp()
    {
        if (baby.health < 5)
        {
            baby.healthUI[4 - baby.health].SetActive(true);
            baby.health++;
        }
    }
    void hg()
    {
        if (baby.hunger < 5)
        {
            baby.hungerUI[4 - baby.hunger].SetActive(true);
            baby.hunger++;
        }
    }
    void hy()
    {
        if (baby.happiness < 5)
        {
            baby.happinessUI[4 - baby.happiness].SetActive(true);
            baby.happiness++;
        }
    }
    public void Play()
    {
        baby.happinessUI[0].SetActive(true);
        baby.happinessUI[1].SetActive(true);
        baby.happinessUI[2].SetActive(true);
        baby.happinessUI[3].SetActive(true);
        baby.happinessUI[4].SetActive(true);
        baby.happiness = 5;
        salaryDown = true;
    }
    public void cracker()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string sCost = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        int cost = int.Parse(sCost.Substring(1));
        if (money >= cost)
        {
            money -= cost;
            hg();
        }
    }
    public void bbFood()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string sCost = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        int cost = int.Parse(sCost.Substring(1));
        if (money >= cost)
        {
            money -= cost;
            hg();
            hg();
        }
    }
    public void bbFormula()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string sCost = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        int cost = int.Parse(sCost.Substring(1));
        if (money >= cost)
        {
            money -= cost;
            hg();
            hg();
            hg();
            hg();
            hg();
        }
    }
    public void panadol()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string sCost = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        int cost = int.Parse(sCost.Substring(1));
        if (money >= cost)
        {
            money -= cost;
            hp();
        }
    }
    public void dctrConsul()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string sCost = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        int cost = int.Parse(sCost.Substring(1));
        if (money >= cost)
        {
            money -= cost;
            hp();
            hp();
        }
    }
    public void checkUp()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string sCost = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        int cost = int.Parse(sCost.Substring(1));
        if (money >= cost)
        {
            money -= cost;
            hp();
            hp();
            hp();
            hp();
            hp();
        }
    }
    public void paddle()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string sCost = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        int cost = int.Parse(sCost.Substring(1));
        if (money >= cost)
        {
            money -= cost;
            hy();
        }
    }
    public void plushie()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string sCost = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        int cost = int.Parse(sCost.Substring(1));
        if (money >= cost)
        {
            money -= cost;
            hy();
            hy();
        }
    }
    public void ToGarbage()
    {
        SceneManager.LoadScene("GarbageMan");
    }
    public void ToFastFood()
    {
        SceneManager.LoadScene("FastFood");
    }
}
