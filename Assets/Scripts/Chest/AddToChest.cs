using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToChest : MonoBehaviour
{
    public Chest chest;
    //public GameObject itemButton;

    public void Add(GameObject itemButton)
    {
        for (int i = 0; i < chest.slots.Length; i++)
        {
            if (chest.isFull[i] == false)
            {
                chest.isFull[i] = true;
                Instantiate(itemButton, chest.slots[i].transform, false);
                break;
            }
        }
    }
}
