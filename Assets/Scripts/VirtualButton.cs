﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        birdAnim.SetTrigger("sing");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
 
    }

    private VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;

    // Use this for initialization
    void Start (){
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
