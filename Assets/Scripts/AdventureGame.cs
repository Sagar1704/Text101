using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    // SerializeField - It is available in the Unity inspector
    [SerializeField] Text textStory;
    [SerializeField] Text textTitle;
    [SerializeField] State startingState;

    State state;

    // Use this for initialization
    void Start () {
        this.StartGame();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.SetState(startingState.GetNextStates()[0]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.SetState(startingState.GetNextStates()[1]);
        }
        //else
        //{
        //    StartGame();
        //}
    }

    private void StartGame() {
        this.SetState(startingState);
    }

    void SetState(State currentState) {
        state = currentState;
        textTitle.text = currentState.GetStateTitle();
        textStory.text = currentState.GetStateStory();
    }
}
