using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RandomEvents : MonoBehaviour
{
    public Baby baby;
    public TextMeshProUGUI eventTxt;
    public TextMeshProUGUI aBtn;
    public TextMeshProUGUI bBtn;
    private int rdmEv;
    private string[,] events = new string[8,3]
        {
            {"Child accidently cuts themselves", "Bring to the doctor", "Wash cut and put plaster over"},
            {"Child falls down and gets a bad scrape", "Apply anti-septic and cover wound", "Just let it heal"},
            {"Child sprains body part", "Bring to the doctor", "Put an ice pack over it"},
            {"Child dislocated arm/leg", "Bring to hospital ER", "Bring to normal doctor"},
            {"Bringing child to water park" ,"Accompany child to attractions", "Risk letting child go alone"},
            {"Parent just got a new car", "Buy a child seat for the child's safety", "Just use the normal seat belt "},
            {"Walking along side child beside road", "Make sure child is walking on the inner side of pavement and supervise them", "Just let child walk where they want"},
            {"Child has difficulty breathing", "Bring to doctor to see if anything serious", "Apply Axe Brand Universal medicated oil"}
        };

    public void RdmEvent()
    {
        rdmEv = Random.Range(0, events.GetLength(0) - 1);
        eventTxt.text = events[rdmEv, 0];
        int rdm = Random.Range(1, 2);
        if (rdm == 1)
        {
            aBtn.text = events[rdmEv, 1];
            bBtn.text = events[rdmEv, 2];
        }
        else
        {
            aBtn.text = events[rdmEv, 2];
            bBtn.text = events[rdmEv, 1];
        }
    }
    public void Choose()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        string btnName = btn.GetComponentInChildren<TextMeshProUGUI>().text;
        if (btnName != events[rdmEv, 1])
        {
            baby.health--;
            baby.healthUI[4 - baby.health].SetActive(false);
            gameObject.SetActive(false);
        }
        Time.timeScale= 1;
    }
}
