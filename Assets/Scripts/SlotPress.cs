using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotPress : MonoBehaviour
{
    public Image BIG;
    public Sprite i1, i2, i3,i4,i5,i6;
    public Text description;
    public Text Iname;
    private bool ch = false;
    isp isp;
    private GameObject itemButton;
    AddToChest aToChest;
    public void Use()
    {
        foreach(Transform child in transform)
        {
            switch (child.name)
            {
                case "Vodka(Clone)": BIG.sprite = i1;
                    description.text = "Невероятно сильно тонизирующий напиток уменьшающий страх ценой здоровья";
                    Iname.text = "Водка";
                    break;
                case "Vino(Clone)": BIG.sprite = i2;
                    description.text = "Помогает скрасить серые дни, уменьшая страх ценой здоровья";
                    Iname.text = "Вино";
                    break;
                case "Klinok1(Clone)": BIG.sprite = i3;
                    description.text = "Часть сломанного кинжала, теперь годится разве что как нож";
                    Iname.text = "Рукоять сломанного кинжала";
                    break;
                case "Kluch(Clone)":
                    BIG.sprite = i4;
                    description.text = "Всего лишь ключ и ничего более";
                    Iname.text = "Ключ от чердака";
                    break;
                case "Sol(Clone)": BIG.sprite = i5;
                    description.text = "Незаменимая вещь в борьбе с призраками";
                    Iname.text = "Соль";
                    break;
                case "Tabletki_pamyt(Clone)":
                    BIG.sprite = i6;
                    description.text = "Помогут вспомнить то, чего даже не было[Использовать для сохранения]";
                    Iname.text = "Таплетки для памяти";
                    break;
            }
        }
        if (ch == true)
        {
            foreach(Transform child in transform)
            {
                for (int i = 0; i<isp.aGOs.Length; i++)
                {
                    if (isp.aGOs[i].name == child.name)
                    {
                        itemButton = isp.aGOs[i].go;
                        break;
                    }
                }
            }
            aToChest.Add(itemButton);
        }
    }
}
