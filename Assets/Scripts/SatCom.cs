using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SatCom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float angle = Quaternion.Angle(transform.rotation, Quaternion.identity);
        if (angle < 10)
        {
            SceneManager.LoadScene("level2");
        }

        Debug.Log(angle);
	}
}
