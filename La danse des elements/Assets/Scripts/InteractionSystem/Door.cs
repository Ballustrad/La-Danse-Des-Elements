using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    string IInteractable.InteractionPrompt => _prompt;

    bool IInteractable.Interact(Interactor interactor)
    {
        //throw new System.NotImplementedException();
        Debug.Log(message: "Opening Door!");
        return true;
    }
    
}
