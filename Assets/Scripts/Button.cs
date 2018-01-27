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
    private float releaseDelay = 0;

	void Start (){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	

	void Update (){
        if (isOver && Input.GetMouseButton(0)){
            moveSat();
            releaseDelay = 10;    
        }
        else{
            release();
            spriteRenderer.color = notPressed;
        }
    }

    private void OnTriggerStay2D(Collider2D collision){
        if (collision.CompareTag("Finger")){
            isOver = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if (collision.CompareTag("Finger")){
            isOver = false;
        }
    }

    private void release(){
        if(releaseDelay > 0){
            releaseDelay -= Time.deltaTime * 100;
            moveSat();
            Debug.Log(releaseDelay);
        }
    }

    private void moveSat(){
        com.transform.Rotate(direction * moveSpeed * Time.deltaTime);
        spriteRenderer.color = pressed;
    }
}
