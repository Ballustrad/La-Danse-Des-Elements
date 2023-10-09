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
        var inventory = interactor.GetComponent<Inventory>();

        if (inventory == null) return false;
        
        if (inventory.HasKey)
        {
            Debug.Log(message: "Opening Door !");
            return true;
        }

        Debug.Log(message: "No Key Found !");
        return true;
    }
    
}
