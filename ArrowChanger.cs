using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowChanger : MonoBehaviour
{


    public GameObject arrow;
    public Sprite left;
    public static bool xdir = false;


    public Sprite up;




    // Update is called once per frame
   
    void Update()
    {
        
        if (FindPose.switc)
        {
            if (!xdir)
            {
                Sprite arrow = GameObject.Find("Arrow").GetComponent<Image>().sprite = left;

                xdir = true;
            }
            else
            {
                Sprite arrow = GameObject.Find("Arrow").GetComponent<Image>().sprite = up;
                xdir = false;
            }
            FindPose.switc = false;

        }
    }
}
