/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDialogueInteract : MonoBehaviour
{
    
    public int bek = 0;
 

    public void bekplus()
    {
        if (bek == 0)
        {
            bek = 2;
        }
        else if (bek != 0)
        {
            bek = 9;
        }
    }
    
    private void Update()
    { 
          
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (bek == 0)
            {
                float interactRange = 2f; //Get Quest
                Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
                foreach (Collider collider in colliderArray)
                {
                    if (collider.TryGetComponent(out DialogueTrigger0 dialogueTrigger))
                    {

                        dialogueTrigger.TriggerDialogue0();
                        bek += 1;

                    }



                }
            }
            else if (bek == 2) //When Player Not Get Quest Yet
            {
                float interactRange = 2f;
                Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
                foreach (Collider collider in colliderArray)
                {
                    if (collider.TryGetComponent(out DialogueTrigger0 dialogueTrigger))
                    {

                        dialogueTrigger.TriggerDialogue0();
                        bek = 9;

                    }



                }
            }
            else if (bek == 1)//when player get quest but not get object yet
            {
                float interactRange = 2f;
                Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
                foreach (Collider collider in colliderArray)
                {
                    if (collider.TryGetComponent(out DialogueTrigger1 dialogueTrigger))
                    {

                        dialogueTrigger.TriggerDialogue1();

                    }



                }
            }
            else if (bek == 9)//when player complete
            {
                float interactRange = 2f;
                Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
                foreach (Collider collider in colliderArray)
                {
                    if (collider.TryGetComponent(out DialogueTrigger2 dialogueTrigger))
                    {

                        dialogueTrigger.TriggerDialogue2();
                        bek = 5;
                    }



                }
            }
            else if (bek == 5) // when got nothing to do
            {
                float interactRange = 2f;
                Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
                foreach (Collider collider in colliderArray)
                {
                    if (collider.TryGetComponent(out DialogueTrigger3 dialogueTrigger))
                    {

                        dialogueTrigger.TriggerDialogue3();

                    }



                }
            }
        }
    }
}*/
