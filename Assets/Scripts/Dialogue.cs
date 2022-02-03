using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Dialogue
{
    public string name;
    [TextArea(1, 2)] //кол-во строк в диалоге 
    public string[] sentences;

}