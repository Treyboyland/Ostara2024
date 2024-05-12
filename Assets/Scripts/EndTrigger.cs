using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField]
    JobRequirements requirements;

    [SerializeField]
    string fakeoutVariableName;

    [SerializeField]
    GameEventEndData endChosenEvent;

    [SerializeField]
    string sceneName;

    [SerializeField]
    GameEventString loadEndSceneEvent;

    [SerializeField]
    EndDataSO immediateLeavingEnding;

    [SerializeField]
    EndDataSO incompleteWorkEnding;

    [SerializeField]
    EndDataSO jobDoneEnding;

    [SerializeField]
    EndDataSO cellarEnding;

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();
        if (player)
        {
            DetermineEnding();
        }
    }

    void DetermineEnding()
    {
        bool endingDetermined = false;

        bool variable = DialogueLua.GetVariable(fakeoutVariableName).asBool;
        EndDataSO ending;

        if (!variable)
        {
            endingDetermined = true;
            ending = immediateLeavingEnding;
        }
        else if (!requirements.AllRequirementsCompleted())
        {
            endingDetermined = true;
            ending = incompleteWorkEnding;
        }
        else
        {
            endingDetermined = true;
            ending = jobDoneEnding;
        }

        //Cellar probably needs its own ending

        if (endingDetermined)
        {
            endChosenEvent.Invoke(ending);
            loadEndSceneEvent.Invoke(sceneName);
        }
    }

    public void ChooseEnding(EndDataSO endData)
    {
        endChosenEvent.Invoke(endData);
        loadEndSceneEvent.Invoke(sceneName);
    }
}
