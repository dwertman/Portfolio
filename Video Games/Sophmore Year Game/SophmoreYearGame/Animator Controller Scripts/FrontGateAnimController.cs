﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontGateAnimController : MonoBehaviour {
    
    Animator gateAnim;
    bool isOpen = false;

	// Use this for initialization
	void Start () {

        gateAnim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<FrontDoorPuzzle>().doorIsOpen && !isOpen)
        {
            gateAnim.Play("OpenGate");
            isOpen = true;
        }
        else if (!GetComponent<FrontDoorPuzzle>().doorIsOpen && isOpen)
        {
            gateAnim.Play("CloseGate");
            isOpen = false;
        }

        //if (Input.GetKeyDown(KeyCode.O) && !isOpen)
        //{
        //    gateAnim.Play("OpenGate");
        //    isOpen = true;
        //}
        //else if (Input.GetKeyDown(KeyCode.O) && isOpen)
        //{
        //    gateAnim.Play("CloseGate");
        //    isOpen = false;
        //}
    }
}
