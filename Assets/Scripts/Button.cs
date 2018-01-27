using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public GameObject com;
    public Vector3 direction;

    public Color pressed;
    public Color notPressed;

    bool isOver;

    private float moveSpeed = 20;
    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isOver && Input.GetMouseButton(0))
        {
            com.transform.Rotate(direction * moveSpeed * Time.deltaTime);
            spriteRenderer.color = pressed;
        }
        else
        {
            spriteRenderer.color = notPressed;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finger"))
        {
            isOver = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Finger"))
        {
            isOver = false;
        }
    }
}
