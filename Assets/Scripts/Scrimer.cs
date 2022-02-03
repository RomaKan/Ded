using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
public class Scrimer : MonoBehaviour
{
    private UnityEngine.Experimental.Rendering.Universal.Light2D li;
    private BoxCollider2D coll;
    int i = 0;
    AudioSource Au;
    void Start()
    {
        li = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
        coll = GetComponent<BoxCollider2D>();
        //Au= GetComponent<AudioSource>();

    }
    IEnumerator Scrim()
    {
        
        i++;

        li.enabled = !li.enabled;
        yield return new WaitForSeconds(0.1f);
        if (i < 55)
        {
            StartCoroutine(Scrim());
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player") {
            StartCoroutine(Scrim());
            coll.enabled = !coll.enabled;
            //Au.Play();
            GameObject.FindObjectOfType<AudioManager>().PlayIt("Lamp");
        }
    }
    
    void Update()
    {
        
    }
}
