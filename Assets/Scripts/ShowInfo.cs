using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowInfo : MonoBehaviour {

    public GameObject popup;
    public Color pressed;
    public Color notPressed;

    private float popArea;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start ()
    {
        print(111);

        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 5)
        {
            popArea = Screen.width - (Screen.width / 3.5f);

        }
        else if(SceneManager.GetActiveScene().buildIndex == 8)
        {
            popArea = Screen.width - (Screen.width / 3);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            popArea = Screen.width - (Screen.width / 5f);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            popArea = Screen.width - (Screen.width / 4f);
        }
        else {
            popArea = Screen.width - (Screen.width / 3);
        }
    }
	
	void Update () {
        //Debug.Log(mousePosition);
        //if (mousePosition.x > 5.4){

        //}

        bool toggle = Input.mousePosition.x >= popArea;

        popup.SetActive(toggle);

        spriteRenderer.color = notPressed;
        if (toggle)
            spriteRenderer.color = pressed;
    }
}
