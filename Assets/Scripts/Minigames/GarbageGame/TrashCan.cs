using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    public GameObject doneUI;
    public GameObject trashTutorial;
    public GameObject trash;
    public TextMeshProUGUI earned;
    public static int trashAmt;
    private int done = 0;
    private bool shouldSpawn = true;
    void Start()
    {
        trashAmt = 5;
        if (trashTutorial.activeInHierarchy)
        {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
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
        if (trashAmt == 0 )
        {
            Spawn();
            trashAmt = 5;
            done++;
        }
    }

    public void Spawn()
    {
        if (shouldSpawn)
        {
            for (int i = 1; i <= 5; i++)
            {
                float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);

                float spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

                Instantiate(trash, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
            }
        }      
    }
}
