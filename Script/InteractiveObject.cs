using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveObject : MonoBehaviour
{
    public float radius = 3f; // กำหนดระยะการมองเห็น
    public Transform player;
    public Transform interactItem;
    bool hasInteract = false; // ชนกันรึยัง
    public GameObject MessagePanel;
    public Item item;
    



    private void Start()
    {
        MessagePanel.SetActive(false);
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, interactItem.position);
        if (distance <= radius && !hasInteract)
        {
            MessagePanel.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {

                hasInteract = true;
                Interact();
                pickup();

            }
        }
        else
        {
            MessagePanel.SetActive(false);
        }
     
    }
    void pickup()
    {
        Inventory.Instance.Add(item);
        
        Destroy(gameObject);
        MessagePanel.SetActive(false);
        
    }

    public virtual void Interact()
    {
        Debug.Log("Interact");
    }
    // สร้างขอบเขตการชน หรือ บริเวณที่เจอ
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactItem.position, radius);
    }

   
}
