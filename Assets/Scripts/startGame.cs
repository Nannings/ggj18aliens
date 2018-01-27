using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    private Transition trans;

    private void Awake()
    {
        trans = FindObjectOfType<Transition>();
    }

    public void loadScene(int index)
    {
        if (enabled)
        {
            enabled = false;
            trans.PlayAnimation("Exit");
            Invoke("LoadScene", 1);
        }
    }

    private void LoadScene()
    {
        //SceneManager.LoadScene(int index);
        SceneManager.LoadScene(1);
    }
}
