using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   public Slider slider;
   public Gradient gradient;
   public Image fill;

   public void SetMaxHealth(int currentHealth)
   {
    slider.maxValue = currentHealth;
    slider.value = currentHealth;

    fill.color = gradient.Evaluate(1f);
   }

   public void SetHealth(int currentHealth)
   {
    slider.value = currentHealth;
    //normalizedValue permets de transformer 100 en une valeur comprise entre 0 et 1.
    fill.color = gradient.Evaluate(slider.normalizedValue);
   }
}