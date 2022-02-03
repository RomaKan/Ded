using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsUsing : MonoBehaviour
{
    public Text Iname;
    public void Use()
    {
        foreach(Transform child in transform)
        {
            switch (child.name)
            {
                case "Водка": Debug.Log("Romnik gay!");
                    //GameObject.FindObjectOfType<AudioManager>().PlayIt("Radio");
                    break;
               
            }
        }
        
    }
}
