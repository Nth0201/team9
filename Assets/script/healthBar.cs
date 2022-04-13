using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthBar : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;
    public void Start()
    {
        slider.maxValue = 100;
        slider.minValue = 0;
        slider.value = 100; 
    }
    public void SetHelth( int health)
    {
        slider.value = health;
    }
    public float getHealth()
    {
        return slider.value;
    }
}
