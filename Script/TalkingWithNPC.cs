using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkingWithNPC : MonoBehaviour
{
	public GameObject TalkingButton;
	public Transform player;
	public Transform npc;
	public float radius = 3f;
	bool hasInterct = false;

	private void Start()
	{
		TalkingButton.SetActive(false);
	}

	void Update()
	{
		float distance = Vector3.Distance(player.position, npc.position);
		if (distance <= radius && !hasInterct)
		{
			TalkingButton.SetActive(true);
		}
		else
		{
			TalkingButton.SetActive(false);
		}
	}
	
	
	private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(npc.position, radius);
    }
}
