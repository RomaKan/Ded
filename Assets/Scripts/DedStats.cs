using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DedStats : MonoBehaviour
{
    public float hp = 1f;
    public float fr = 0f;
    public Slider hpSlider;
    public Slider frSlider;

    void Start()
    {
        hpSlider.value = hp;
        frSlider.value = fr;
    }

    public void SetHealth(float health)
    {
        hp -= health;
        hpSlider.value = hp;
    }

    public void SetFear(float fear)
    {
        fr += fear;
        frSlider.value = fr;
    }
}
