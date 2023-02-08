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
    public GameObject wConfirm;
    public TextMeshProUGUI plusTxt;
    public TextMeshProUGUI minusTxt;
    public TextMeshProUGUI moneyTxt;
    public static int money = 100;
    public static bool salaryDown;

    public GameObject wRandom;
    public GameObject wRandomPicked;
    public GameObject wJob;

    private void Update()
    {
        moneyTxt.text = money.ToString();
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
        wConfirm.SetActive(false);
        wRandomPicked.SetActive(false);
    }
    public void work()
    {
        wJob.SetActive(true);
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
        if (Baby.health < 5)
        {
            baby.healthUI[4 - Baby.health].SetActive(true);
            Baby.health++;
        }
    }
    void hg()
    {
        if (Baby.hunger < 5)
        {
            baby.hungerUI[4 - Baby.hunger].SetActive(true);
            Baby.hunger++;
        }
    }
    void hy()
    {
        if (Baby.happiness < 5)
        {
            baby.happinessUI[4 - Baby.happiness].SetActive(true);
            Baby.happiness++;
        }
    }
    public void Play()
    {
        baby.happinessUI[0].SetActive(true);
        baby.happinessUI[1].SetActive(true);
        baby.happinessUI[2].SetActive(true);
        baby.happinessUI[3].SetActive(true);
        baby.happinessUI[4].SetActive(true);
        Baby.happiness = 5;
        salaryDown = true;
        wConfirm.SetActive(true);
        plusTxt.text = "Baby is happy!";
        minusTxt.text = "Salary is cut in half!";
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
            wConfirm.SetActive(true);
            plusTxt.text = "Baby hunger increased by 1!";
            minusTxt.text = "You used $" + cost + "\n" +  "Money left: $ " +money.ToString();
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
            wConfirm.SetActive(true);
            plusTxt.text = "Baby hunger increased by 2!";
            minusTxt.text = "You used $" + cost + "\n" + "Money left: $ " + money.ToString();
            Debug.Log("Bought baby food");
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
            wConfirm.SetActive(true);
            plusTxt.text = "Baby hunger is full!";
            minusTxt.text = "You used $" + cost + "\n" + "Money left: $ " + money.ToString();
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
            wConfirm.SetActive(true);
            plusTxt.text = "Baby health increased by 1!";
            minusTxt.text = "You used $" + cost + "\n" + "Money left: $ " + money.ToString();
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
            wConfirm.SetActive(true);
            plusTxt.text = "Baby health increased by 2!";
            minusTxt.text = "You used $" + cost + "\n" + "Money left: $ " + money.ToString();
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
            wConfirm.SetActive(true);
            plusTxt.text = "Baby health is full!";
            minusTxt.text = "You used $" + cost + "\n" + "Money left: $ " + money.ToString();
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
            wConfirm.SetActive(true);
            plusTxt.text = "Baby happiness increased by 1!";
            minusTxt.text = "You used $" + cost + "\n" + "Money left: $ " + money.ToString();
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
            wConfirm.SetActive(true);
            plusTxt.text = "Baby happiness increased by 2!";
            minusTxt.text = "You used $" + cost + "\n" + "Money left: $ " + money.ToString();
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

    public void Restart()
    {
        Baby.health = 5;
        Baby.hunger = 5;
        Baby.happiness = 5;
        SceneManager.LoadScene("Reworked");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
