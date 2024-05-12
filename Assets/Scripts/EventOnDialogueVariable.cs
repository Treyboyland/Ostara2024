using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.Events;

public class EventOnDialogueVariable : MonoBehaviour
{
    [SerializeField]
    string variableName;

    [SerializeField]
    bool fireOnce;

    bool fired = false;

    public UnityEvent OnTriggered;

    // Update is called once per frame
    void Update()
    {
        var variable = DialogueLua.GetVariable(variableName).asBool;

        if (variable && (!fireOnce || (fireOnce && !fired)))
        {
            fired = true;
            OnTriggered.Invoke();
        }
    }
}
