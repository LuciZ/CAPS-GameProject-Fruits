﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBigger : item {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Action(Collider obj)
    {
        Fruits.instance.Bigger();
    }
}
