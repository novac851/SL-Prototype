using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaManager : MonoBehaviour
{
   public Text actorName;
   public Text messageText;
   public RectTransform backgroundBox;

   Message[] currentMessages;
   Actor[] currentActors;
   int activeMessage = 0;
   public static bool isActive = false;
   
  
  

   public void OpenDialogue(Message[] messages, Actor[] actors)
   {
	   currentMessages = messages;
	   currentActors = actors;
	   activeMessage = 0;
	   isActive = true;
	   Debug.Log("Started conversation: " + messages.Length);
	   DisplayMessage();
	   backgroundBox.LeanScale(Vector3.one, 0.5f);
   }

   void DisplayMessage()
   {
	   Message messageToDisplay = currentMessages[activeMessage];
	   messageText.text = messageToDisplay.message;

	   Actor actorToDisplay = currentActors[messageToDisplay.actorId];
	   actorName.text = actorToDisplay.name;
	  
   }

   public void NextMessage()
   {
	   activeMessage++;
	   if(activeMessage < currentMessages.Length)
	   {
		   DisplayMessage();
	   } else {
		   Debug.Log("Conversation End");
		   isActive = false;
	   }
   }

   void Start()
   {
	   backgroundBox.transform.localScale = Vector3.zero;
	   
   }
  
   void Update()
   {
	   if(Input.GetKeyDown(KeyCode.E) && isActive == true)
	   {
		   NextMessage();
	   }
   }
}
