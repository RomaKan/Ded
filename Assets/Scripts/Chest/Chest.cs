using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public Image background;
    private bool isActive = false;

    void Start()
    {
        background.gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.I) && isActive == false)
            {
                background.gameObject.SetActive(true);
                isActive = true;
            }
            else if (Input.GetKeyDown(KeyCode.I) && isActive == true)
            {
                background.gameObject.SetActive(false);
                isActive = false;
            }
        }
    }
}
