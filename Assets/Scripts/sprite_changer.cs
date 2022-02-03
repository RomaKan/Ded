using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_changer : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite r;

     
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.FindObjectOfType<AudioManager>().PlayIt("Otkritie");
            rend.sprite = r;

        }
    }
    
}
