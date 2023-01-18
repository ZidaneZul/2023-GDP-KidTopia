using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public GameObject[] orders;
    public GameObject[] ordersUp;
    public Transform[] positions;
    public GameObject fastTutorial;
    public GameObject doneUI;
    public TextMeshProUGUI earned;
    public int served;
    private int done;
    private bool shouldSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        if (fastTutorial.activeInHierarchy)
        {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (served == 5)
        {
            done++;
            if (done == 1)
            {
                if (Manager.salaryDown)
                {
                    earned.text += " (-50%)";
                }
                doneUI.SetActive(true);
                shouldSpawn = false;
                Timer.timerOn = false;
            }
            FFspawn();
            served = 0;
        }
    }

    public void FFspawn()
    {
        if (shouldSpawn)
        {
            foreach (Transform i in positions)
            {
                GameObject go = Instantiate(orders[Random.Range(0, orders.Length)], i);
            }
        }
    }
}
