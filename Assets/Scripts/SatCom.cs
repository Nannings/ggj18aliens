using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SatCom : MonoBehaviour
{
    private CanvasHud canvasHud;

<<<<<<< HEAD
    private void Awake()
    {
        canvasHud = FindObjectOfType<CanvasHud>();
    }

    void Update () {
        float angle = Quaternion.Angle(transform.rotation, Quaternion.identity);
        if (angle < 10)
        {
=======
	void Start () {
		
	}
	
	void Update () {
        float angle = Quaternion.Angle(transform.rotation, Quaternion.identity); //.identity = no Rotation
        if (angle < 10){
>>>>>>> 41c4b2eea19d3a0d202fc8f4e508e8661c5d7c54
            SceneManager.LoadScene("level2");
        }

        canvasHud.ChangeWifi(angle);
        
	}
}
