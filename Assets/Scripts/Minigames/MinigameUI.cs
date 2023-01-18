using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameUI : MonoBehaviour
{
    public int earn;
    public GameObject tutorial;
    public TrashCan trashCan;
    public Customer customer;
    public void Back()
    {
        if (Manager.salaryDown)
        {
            Manager.money += Mathf.FloorToInt(earn/2);
        }
        else
        {
            Manager.money += earn;
        }
        SceneManager.LoadScene("Reworked");
    }
    public void CloseTutorial()
    {
        tutorial.SetActive(false);
        if (SceneManager.GetActiveScene().name == "GarbageMan")
        {
            Time.timeScale = 1;
            trashCan.Spawn();
        }
        if (SceneManager.GetActiveScene().name == "FastFood")
        {
            Time.timeScale = 1;
            customer.FFspawn();
            customer.served = 0;
        }
    }
}
