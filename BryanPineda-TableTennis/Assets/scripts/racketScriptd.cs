﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racketScriptd : MonoBehaviour 
{

	// Use this for initialization
	void Start()
    {
		
	}
	

	// Update is called once per frame
	void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.left * 0.2f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.right * 0.2f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.back * 0.2f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.forward *0.2f);
        }
    }
}
