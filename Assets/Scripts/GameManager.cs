using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager _instance;
    public AudioClip complete;

    private AudioSource audioSource;

    // Use this for initialization
    void Awake () {
        if (_instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void PlayComplete()
    {
        audioSource.PlayOneShot(complete);
    }
}
