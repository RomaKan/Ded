using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSlot : MonoBehaviour
{
    public Chest chest;
    public int i = 0;

    private void Start()
    {
       // chest = GameObject.FindGameObjectWithTag("Player").GetComponent<Chest>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            chest.isFull[i] = false;
        }
    }
}
