using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The scriptable object does not need to be attached to the GameObject
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
    [TextArea(10, 14)] [SerializeField] string storyText;
    [TextArea(10, 14)] [SerializeField] string storyTitle;

    [SerializeField] State[] nextStates;

    public string GetStateTitle() {
        return storyTitle;
    }

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates() {
        return nextStates;
    }
}
