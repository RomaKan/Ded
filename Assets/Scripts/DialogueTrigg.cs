using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigg : MonoBehaviour
{
    public Dialogue dialogue;
   
    void Start()
    {
        
       

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
           
            
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }

    }
   
   
}