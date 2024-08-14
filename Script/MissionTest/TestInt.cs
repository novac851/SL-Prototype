using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInt : MonoBehaviour
{
    private void update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            
                float interactRange = 2f; //Get Quest
                Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
                foreach (Collider collider in colliderArray)
                {
                    if (collider.TryGetComponent(out DiaTrigger dialogueTrigger))
                    {

                        dialogueTrigger.StartDialogue();
                        

                    }
                }
            
        }
    }
}
