using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void Play()
    {
        Baby.health = 5;
        Baby.hunger = 5;
        Baby.happiness = 5;
        SceneManager.LoadScene("Reworked");
    }
}
