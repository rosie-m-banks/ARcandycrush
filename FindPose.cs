using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using Unity.Collections;
using Unity.Jobs;

[RequireComponent(typeof(ARTrackedImageManager))]
public class FindPose : MonoBehaviour
{

    bool on = true;
    double startX;
    double startY;

    public static bool switc = true;



    void Awake() {
        ScoreDisplay.score = 0;
    }

    void Update()
    {

        var m_TrackedImageManager = GetComponent<ARTrackedImageManager>();

        

            foreach (ARTrackedImage trackedImage in m_TrackedImageManager.trackables)
            {
                // Handle updated event

                Vector3 newPose = trackedImage.transform.position;

                double x = newPose.x; //= newPose.x;
                
                double y = newPose.y;

                if (on)
                {
                    startX = x;
                    startY = y;
                    on = false;
                }

            if (startX - x == .015 || x - startX == .015 || startY - y == .015 || y- startY == .015)
            {
                ScoreDisplay.score += 1;
                on = true;
                switc = true;
            }




        }


        
    }

}
