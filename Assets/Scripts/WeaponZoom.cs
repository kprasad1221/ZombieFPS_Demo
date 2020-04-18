using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera cameraView;
    [SerializeField] float zoomInFOV = 30f;
    [SerializeField] float zoomOutFOV = 60f;
    bool isZoomedIn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (isZoomedIn == false)
            {
                cameraView.fieldOfView = zoomInFOV;
                isZoomedIn = true;
            }
            else
            {
                cameraView.fieldOfView = zoomOutFOV;
                isZoomedIn = false;
            }
            
        }
    }
}
