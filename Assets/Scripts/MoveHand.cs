using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveHand : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        if (SceneManager.GetActiveScene().name == "mainMenu")
        {
            Cursor.visible = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePosition += cursorOffset;
        mousePosition.z = 0;
        transform.position = mousePosition;
    }
}
