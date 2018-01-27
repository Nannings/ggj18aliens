using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SatCom : MonoBehaviour {
    private CanvasHud canvasHud;
    private int level;

    private void Awake()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        canvasHud = FindObjectOfType<CanvasHud>();
    }

	void Update ()
    {
        if (Input.GetKey(KeyCode.C))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, 2 * Time.deltaTime);
        }

        float angle = Quaternion.Angle(transform.rotation, Quaternion.identity); //.identity = no Rotation
        if (angle < 10){
            print("level complete!!!");
            level++;
            if (level > 6){
                level = 0;
            }
            SceneManager.LoadScene(level);
        }
        canvasHud.ChangeWifi(angle);   
	}
}