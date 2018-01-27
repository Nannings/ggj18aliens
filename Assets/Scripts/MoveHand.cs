using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveHand : MonoBehaviour
{
    private string sceneName;

	// Use this for initialization
	void Start () {
        sceneName = SceneManager.GetActiveScene().name;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Cursor.visible = sceneName == "mainMenu";

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePosition += cursorOffset;
        mousePosition.z = 0;
        transform.position = mousePosition;
    }
}
