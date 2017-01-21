﻿using UnityEngine;
using System.Collections;

public class InteractSatScript : MonoBehaviour {

	
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if ((hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero)))
            {
                if (hit.collider.tag == "Satellite")
                {
                    Debug.Log("is satellite (left click)");
                    RotateSat();

                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if ((hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero)))
            {
                if (hit.transform.tag == "Satellite")
                {
                    RotateSat();
                    Debug.Log("is satellite (right click)");
                }
            }
        }
    }

    void DeleteSat()
    {

    }

    void RotateSat()
    {

    }
}
