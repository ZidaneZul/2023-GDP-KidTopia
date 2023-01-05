using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyStates : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BabyExpectancy();
    }

    void BabyExpectancy() 
    //gets called after a random event
    {
        if (Input.GetKeyDown(KeyCode.L)) 
            //player made a very bad choice
        {
            Debug.Log("The life expectancy of the baby has droped! "
                + Random.Range(-11, -20) + " Years");
        }
        if (Input.GetKeyDown(KeyCode.K))
        //player made a bad choice
        {
            Debug.Log("The life expectancy of the baby has droped! "
                + Random.Range(-1, -10) + " Years");
        }
        if (Input.GetKeyDown(KeyCode.J))
        //player made a good choice
        {
            Debug.Log("The life expectancy of the baby has increased! "
                + Random.Range(1, 10) + " Years");
        }
        if (Input.GetKeyDown(KeyCode.H))
        //player made a good choice
        {
            Debug.Log("The life expectancy of the baby has increased! "
                + Random.Range(10, 20) + " Years");
        }
    }
}
