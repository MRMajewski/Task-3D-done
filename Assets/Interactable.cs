using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [HideInInspector]
    public float distanceToPlayer;

    public float BorderDistanceToPlayer;

    [HideInInspector]
    public PlayerInteractionComponent Player;


    private void Update()
    {
            if (Input.GetKey(KeyCode.E))
        {
            if (CanInteractable())
                Interact();
        }        
        }
  

    private void OnTriggerEnter(Collider other)
    {
        Player = other.GetComponent<PlayerInteractionComponent>();
        Player.interactable = true;
    

    }

    private void OnTriggerExit(Collider other)
    {
        Player = other.GetComponent<PlayerInteractionComponent>();
        Player.interactable = false;
    }

    public virtual bool CanInteractable()
    { 

        if (Player == null || !(Player.interactable))
            return false;
        else

            distanceToPlayer = Vector3.Distance(Player.transform.position, transform.position);
        if ((distanceToPlayer <= BorderDistanceToPlayer))
        
        {
            Debug.Log("Można się integrować");
            return true;
        }        
        else return false;
    }

    public virtual void Interact()
    {
        Debug.Log("Dokonałem interakcji");
    }
}
