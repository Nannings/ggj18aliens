using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowInfo : MonoBehaviour {

    public GameObject popup;
    private float popArea;

    void Start ()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 5)
        {
            popArea = Screen.width - (Screen.width / 3.5f);

        }
        else if(SceneManager.GetActiveScene().buildIndex == 7)
        {
            popArea = Screen.width - (Screen.width / 3);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            popArea = Screen.width - (Screen.width / 5f);
        }
        else {
            popArea = Screen.width - (Screen.width / 4);
        }
    }
	
	void Update () {
        //Debug.Log(mousePosition);
        //if (mousePosition.x > 5.4){

        //}

        popup.SetActive(Input.mousePosition.x >= popArea);
    }
}
