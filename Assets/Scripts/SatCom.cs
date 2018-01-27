using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SatCom : MonoBehaviour
{
    private CanvasHud canvasHud;

    private void Awake()
    {
        canvasHud = FindObjectOfType<CanvasHud>();
    }

    void Update () {
        float angle = Quaternion.Angle(transform.rotation, Quaternion.identity);
        if (angle < 10)
        {
            SceneManager.LoadScene("level2");
        }

        canvasHud.ChangeWifi(angle);
        
	}
}
