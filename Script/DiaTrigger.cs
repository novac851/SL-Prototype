using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;


    public void StartDialogue()
    {
        
        FindObjectOfType<DiaManager>().OpenDialogue(messages, actors);
    }
}
    
[System.Serializable]
public class Message
{
        public int actorId;
        public string message;
}

[System.Serializable]
public class Actor
{
        public string name;
}

