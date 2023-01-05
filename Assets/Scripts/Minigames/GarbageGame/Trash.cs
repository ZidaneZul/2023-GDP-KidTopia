using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Trash : MonoBehaviour
{
    Vector3 mousePosition;

    private void OnMouseDown()
    {
        mousePosition = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + mousePosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bin")
        {
            Destroy(gameObject);
        }
    }
}
