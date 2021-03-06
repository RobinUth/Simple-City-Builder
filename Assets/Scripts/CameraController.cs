﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // change size to zoom in/out
    // clamp values to min and max
    // mouse wheel scroll
    private Vector3 mouseOriginPoint;
    private Vector3 offset;
    private bool dragging;

    private void LateUpdate()
    {
       Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * (10f * Camera.main.orthographicSize * 0.1f), 2.5f, 50f);

        if (Input.GetMouseButton(0))
        {
            offset = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
            if(!dragging)
            {
                dragging = true;
                mouseOriginPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }else
        {
            dragging = false;
        } 
        if(dragging)
        {
            transform.position = mouseOriginPoint - offset;
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
