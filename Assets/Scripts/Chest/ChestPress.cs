using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestPress : MonoBehaviour
{
    Inventory inventory;
    private GameObject itemButton;
    PickUp pickup;
    isp isp;

    public void AddToInv()
    {
       foreach (Transform child in transform)
       {
            for (int i = 0; i< isp.aGOs.Length; i++)
            {
              if (isp.aGOs[i].name == child.name)
              {
                    itemButton = isp.aGOs[i].go;
                    pickup.Add(itemButton);
                    break;
              }
            }
            Destroy(child.gameObject);
       }
    }
}
