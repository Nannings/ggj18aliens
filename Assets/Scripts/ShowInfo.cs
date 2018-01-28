using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour {

    public GameObject popup;

	
	void Start () {
	}
	
	void Update () {
        //Debug.Log(mousePosition);
        //if (mousePosition.x > 5.4){

        //}
        float popArea = Screen.width - (Screen.width / 3);
        popup.SetActive(Input.mousePosition.x >= popArea);
    }
}
