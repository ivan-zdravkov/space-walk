﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        this.state = this.startingState;

        this.textComponent.text = this.state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        this.ManageState();
    }

    private void ManageState()
    {
        State[] nextStates = this.state.GetNextStates();

        if(Input.GetKeyDown(KeyCode.Alpha1) && nextStates.Length > 0)
        {
            this.state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && nextStates.Length > 1)
        {
            this.state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && nextStates.Length > 2)
        {
            this.state = nextStates[2];
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            this.state = this.startingState;
        }

        this.textComponent.text = this.state.GetStateStory();
    }
}
