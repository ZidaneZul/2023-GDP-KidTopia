using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using Unity.VisualScripting;

public class FastFood : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 ogPos;

    private void Start()
    {
        ogPos = transform.position;
    }
    private void OnMouseDown()
    {
        mousePosition = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + mousePosition;
    }
    private void OnMouseUp()
    {
        transform.position = ogPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == gameObject.name)
        {
            collision.gameObject.SetActive(false);
            transform.position = ogPos;
        }
    }
}
