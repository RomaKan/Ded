using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))//нажатие кнопки добавить
        {
            for (int i = 0; i<inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    FindObjectOfType<AudioManager>().PlayIt("loot");
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }    
    }

    public void Add(GameObject ib)
    {
        for (int i = 0; i<inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;
                Instantiate(ib, inventory.slots[i].transform, false);
                break;
            }
        }
    }
}
