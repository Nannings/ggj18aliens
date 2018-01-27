using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHud : MonoBehaviour
{
    public Sprite[] wifiSprites;
    public Image wifiImage;

    public void ChangeWifi(float wifi)
    {
        if (wifi < 30)
        {
            wifiImage.sprite = wifiSprites[0];
        }
        else if (wifi < 90)
        {
            wifiImage.sprite = wifiSprites[1];
        }
        else if (wifi < 180)
        {
            wifiImage.sprite = wifiSprites[2];
        }
        else
        {
            wifiImage.sprite = wifiSprites[3];
        }
    }
}
