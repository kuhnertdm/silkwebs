﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachHook : MonoBehaviour {

    /// <summary>
    /// Hook prefab
    /// </summary>
    public GameObject hookPrefab;

    internal GameObject curHook;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseScreenPoint = Input.mousePosition;
            mouseScreenPoint.z = -Camera.main.transform.position.z;
            Vector2 mouseWorldPoint = Camera.main.ScreenToWorldPoint(mouseScreenPoint);

            // Instatiate hook on player's position.
            curHook = Instantiate(hookPrefab, transform.position, 
                                  Quaternion.identity) as GameObject;

            curHook.GetComponent<Silk>().destination = mouseWorldPoint;
        }
    }
}
