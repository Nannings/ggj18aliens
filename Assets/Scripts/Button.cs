using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public GameObject com;
    public Vector3 direction;
    public Color pressed;
    public Color notPressed;
    public bool hasDelay;

    private float moveSpeed = 50;
    private bool isOver;
    private SpriteRenderer spriteRenderer;
    private float releaseDelay = 0;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        com = FindObjectOfType<SatCom>().gameObject;
    }


    void Update()
    {
        if (isOver && Input.GetMouseButton(0))
        {
            moveSat();
            releaseDelay = 10;
        }
        else
        {
            release();
            spriteRenderer.color = notPressed;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finger"))
        {
            isOver = true;
            if (collision.gameObject.name == "Zuignap")
            {
                hasDelay = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Finger"))
        {
            isOver = false;
        }
    }

    private void release()
    {
        if (releaseDelay > 0 && hasDelay)
        {
            releaseDelay -= Time.deltaTime * 10;
            moveSat();
            spriteRenderer.color = notPressed;
        }
        else
        {
            releaseDelay = 0;
        }
    }

    private void moveSat()
    {
        com.transform.Rotate(direction * moveSpeed * Time.deltaTime);
        spriteRenderer.color = pressed;
    }
}
