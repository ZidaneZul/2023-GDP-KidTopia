using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyManager : MonoBehaviour
{
    public int intelligence, charisma, health;

    public int life = 70;

    private void Awake()
    {
        intelligence = Random.Range(0, 100); //how smort
        charisma = Random.Range(0, 100); // how well they can bargain etc
        health = Random.Range(0, 100); // life expectancy
    }
}
