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
    private Collider2D col;
    private EyeToggle closedEye;
    public bool isPressed;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        com = FindObjectOfType<SatCom>().gameObject;
        closedEye = FindObjectOfType<EyeToggle>();
    }


    void Update()
    {
        if (isOver && (Input.GetMouseButton(0) || col.CompareTag("PlantEdge")))
        {
            moveSat();
            releaseDelay = 10;
            //Debug.Log("isOver & input");
            if (closedEye != null)
            {
                closedEye.toggle("pressed");
            }

            isPressed = true;
        }
        else{
            release();
            }
    }

    private void OnTriggerStay2D(Collider2D collision){
        col = collision;
        if (col.CompareTag("Finger") || col.CompareTag("PlantEdge")){

            isOver = true;
            
            if (collision.gameObject.name == "Zuignap"){
                hasDelay = true;
            }
            if (collision.CompareTag("PlantEdge"))
            {
                moveSat();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Finger") || collision.CompareTag("PlantEdge"))
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
            spriteRenderer.color = pressed;
        }
        else
        {
            releaseDelay = 0;
            spriteRenderer.color = notPressed;
        }

        if (closedEye != null)
        {
            closedEye.toggle("released");
        }

        isPressed = false;
    }

    private void moveSat(){
        com.transform.Rotate(direction * moveSpeed * Time.deltaTime);
        spriteRenderer.color = pressed;
    }
}
