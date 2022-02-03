using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject[] mass=new GameObject[13] ;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            for(int i=0; i<5; i++)
            {
                mass[i].SetActive(false);
            }
            for (int i = 5; i < 13; i++)
            {
                mass[i].SetActive(true);
            }
            FindObjectOfType<AudioManager>().PlayIt("loot");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
