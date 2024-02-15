using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
        public int currentHealth;
        public int maxHealth = 10;
        public HealthBar healthBar;

        private bool isDead; 
        public CurrentSceneManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

   public void TakeDamage(int amount)
   {
    currentHealth -= amount;
    if (currentHealth<=0 && !isDead)
    {
        isDead = true;
        gameManager.gameOver();
        Destroy
        (gameObject);
    }

    if(Input.GetKeyDown(KeyCode.H))
    {
        TakeDamage(20);
    }

    healthBar.SetHealth(currentHealth);

   }
}
