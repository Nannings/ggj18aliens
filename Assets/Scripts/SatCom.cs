using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SatCom : MonoBehaviour {
    private CanvasHud canvasHud;
    private int level;
    private Vector3 startPos;
    private Vector3 goalPos;


    private void Awake()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        canvasHud = FindObjectOfType<CanvasHud>();
        UnityEngine.Random.InitState((int) System.DateTime.Now.Ticks);
        startPos = new Vector3(UnityEngine.Random.Range(-360f, -340f), UnityEngine.Random.Range(-360f, -340f), UnityEngine.Random.Range(-360f, -340f));
        UnityEngine.Random.InitState((int)System.DateTime.Now.Minute * (int)System.DateTime.Now.Millisecond);
        goalPos = new Vector3(UnityEngine.Random.Range(-320f, 360f), UnityEngine.Random.Range(-320f, 360f), UnityEngine.Random.Range(-320f, 360f));
    }

    private void InitState(float value)
    {
        throw new NotImplementedException();
    }

    private void Start(){
        transform.rotation = Quaternion.Euler(startPos);
    }

    void Update ()
    {
        if (Input.GetKey(KeyCode.C))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(goalPos), 2 * Time.deltaTime);
        }

        float angle = Quaternion.Angle(transform.rotation, Quaternion.Euler(goalPos)); //.identity = no Rotation
        if (angle < 20){
            print("level complete!!!");
            level++;
            if (level > 5){
                level = 0;
            }
            SceneManager.LoadScene(level);
        }
        canvasHud.ChangeWifi(angle);   
	}
}