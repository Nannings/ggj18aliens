using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wifi : MonoBehaviour
{
    public Sprite[] wifiSprites;
    public SpriteRenderer wifiImage;

    private void Awake()
    {
        wifiImage = GetComponent<SpriteRenderer>();
    }

    public void ChangeWifi(float wifi)
    {
        if (wifi <= 180 && wifi > 90)
        {
            wifiImage.sprite = wifiSprites[1];
        }
        else if (wifi <= 90 && wifi > 60)
        {
            wifiImage.sprite = wifiSprites[2];
        }
        else if (wifi <= 60 && wifi > 30)
        {
            wifiImage.sprite = wifiSprites[3];
        }

        else if (wifi <= 30)
        {
            wifiImage.sprite = wifiSprites[4];
        }

        else
        {
            wifiImage.sprite = wifiSprites[0];
        }
    }
}
