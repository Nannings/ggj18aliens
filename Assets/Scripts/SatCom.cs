using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SatCom : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        float angle = Quaternion.Angle(transform.rotation, Quaternion.identity); //.identity = no Rotation
        if (angle < 10){
            SceneManager.LoadScene("level2");
        }

        Debug.Log(angle);
	}
}
