using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Baby baby;
    public GameObject wShop;
    public GameObject wFood;
    public GameObject wHealth;
    public GameObject wToy;
    public GameObject wSpecials;

    public GameObject wRandom;
    public GameObject wJob;

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
    public void hp()
    {
        if (baby.health < 5)
        {
            baby.healthUI[4 - baby.health].SetActive(true);
            baby.health++;
        }
    }
    public void hg()
    {
        if (baby.hunger < 5)
        {
            baby.hungerUI[4 - baby.hunger].SetActive(true);
            baby.hunger++;
        }
    }
    public void hy()
    {
        if (baby.happiness < 5)
        {
            baby.happinessUI[4 - baby.happiness].SetActive(true);
            baby.happiness++;
        }
    }
}
