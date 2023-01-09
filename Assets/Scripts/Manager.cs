using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Baby;
    public Transform SpawnPoint;
    public Transform[] BabyMove;

    public GameObject wBaby;
    public GameObject wRandom;
    public GameObject wJob;
    public GameObject wShop;
    public TextMeshProUGUI statText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBaby()
    {
        GameObject gO = (GameObject)Instantiate(Baby, SpawnPoint.position, Quaternion.identity);
        Crawl crawl = gO.GetComponent<Crawl>();
        crawl.moveSpot = BabyMove;
        statText.text = "Int: " + gO.GetComponent<BabyManager>().intelligence + " / " + "Cha: " + gO.GetComponent<BabyManager>().charisma + " / " + "Health: " + gO.GetComponent<BabyManager>().health;
        wBaby.SetActive(true);

        //GameObject gO = Instantiate(Baby, SpawnPoint);
        //statText.text = "Int: " + gO.GetComponent<BabyManager>().intelligence + " / " + 
        //    "Cha: " + gO.GetComponent<BabyManager>().charisma + " / " + 
        //    "Health: " + gO.GetComponent<BabyManager>().health;
        //window.SetActive(true);
    }
    public void CloseWindow()
    {
        wBaby.SetActive(false);
        wRandom.SetActive(false);
        wJob.SetActive(false);
        wShop.SetActive(false);
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
    }


}
