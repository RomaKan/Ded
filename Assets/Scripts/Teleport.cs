using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    public GameObject AlphaObj, Player;
    public Image AlphaImage;
    public GameObject Suda;
    bool perem = false, trig = false, knopka = false, t=false;
    void Start()
    {
        AlphaImage = AlphaObj.GetComponent<Image>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && trig == false && knopka == true)
        {
            
            perem = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" )
        {
            perem = false;
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            knopka = true;
        }
        else { knopka = false; };
        if (perem == true)
        {
            AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a + 2f * Time.deltaTime);
            if (AlphaImage.color.a >= 1.0f)
            {
                GameObject.FindObjectOfType<AudioManager>().PlayIt("Otkritie");
                Player.transform.position = Suda.transform.position;
                t = true;
            }
        }
       
        if (AlphaImage.color.a >= 0 && perem == false && t==true)
        {
            AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a - 0.9f * Time.deltaTime);
            if (AlphaImage.color.a <= 0)
            {
                trig = false;
                t = false;
            }
        }
        

    }
}
