using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public GameObject[] orders;
    public GameObject[] ordersUp;
    public Transform[] positions;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform i in positions)
        {
            GameObject go = Instantiate(orders[Random.Range(0,orders.Length)], i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
