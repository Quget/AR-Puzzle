﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMenu : MonoBehaviour
{
    
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnPrefabSwitchClick()
    {
        Character character = FindObjectOfType<Character>();
        if(character != null)
        {
            character.StartWalking();
        }
    }
}
