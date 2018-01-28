using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeToggle : MonoBehaviour
{
    public GameObject hand1;
    public GameObject hand2;
    public GameObject hand3;
    public GameObject satCom;

    public Button but1;
    public Button but2;
    public Button but3;
    public Button but4;
    public Button but5;
    public Button but6;

    public void toggle(string actionstate){

        if (but1.isPressed || but2.isPressed || but3.isPressed || but4.isPressed || but5.isPressed || but6.isPressed)
        {
            hand1.SetActive(true);
            hand2.SetActive(true);
            hand3.SetActive(true);
            satCom.SetActive(false);
        }
        else
        {
            hand1.SetActive(false);
            hand2.SetActive(false);
            hand3.SetActive(false);
            satCom.SetActive(true);
        }
    }
}
