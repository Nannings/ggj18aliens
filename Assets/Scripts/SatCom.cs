using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SatCom : MonoBehaviour {
    private Wifi wifiIcon;
    private int level;
    private Vector3 startPos;
    private Vector3 goalPos;
    private WifiSound wifiSound;
    private Transition trans;

    private void Awake()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        UnityEngine.Random.InitState((int) System.DateTime.Now.Ticks);
        startPos = new Vector3(UnityEngine.Random.Range(-360f, -340f), UnityEngine.Random.Range(-360f, -340f), UnityEngine.Random.Range(-360f, -340f));
        UnityEngine.Random.InitState((int)System.DateTime.Now.Minute * (int)System.DateTime.Now.Millisecond);
        goalPos = new Vector3(UnityEngine.Random.Range(-320f, 360f), UnityEngine.Random.Range(-320f, 360f), UnityEngine.Random.Range(-320f, 360f));
        wifiIcon = FindObjectOfType<Wifi>();
        wifiSound = FindObjectOfType<WifiSound>();
        trans = FindObjectOfType<Transition>();
    }

    private void InitState(float value)
    {
        throw new NotImplementedException();
    }

    private void Start(){
        transform.rotation = Quaternion.Euler(startPos);
        trans.PlayAnimation("Enter");
    }

    void Update ()
    {
        //if (Input.GetKey(KeyCode.C))
        //{
        //    transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(goalPos), 2 * Time.deltaTime);
        //}

        float angle = Quaternion.Angle(transform.rotation, Quaternion.Euler(goalPos)); //.identity = no Rotation
        if (angle < 20)
        {
            print("level complete!!!");
            Invoke("NextLevel", 1);
            trans.PlayAnimation("Exit");
            enabled = false;
        }

        wifiIcon.ChangeWifi(angle);
        if(wifiSound != null)
            wifiSound.SetSound(angle);


	}

    public void NextLevel()
    {
        GameManager._instance.PlayComplete();
        level++;
        if (level > 10)
        {
            level = 0;
        }
        SceneManager.LoadScene(level);
    }
}