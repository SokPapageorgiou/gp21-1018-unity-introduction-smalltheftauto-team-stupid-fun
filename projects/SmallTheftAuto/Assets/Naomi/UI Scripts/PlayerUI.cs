using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    
    void Update()
    {
        if (currentHealth <= 0)
        {
            
            SceneManager.LoadScene("SceneN");
            
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void Healing(int healing)
    {
        currentHealth += healing;
        currentHealth = Mathf.Clamp(currentHealth, 0, 100);
        healthBar.SetHealth(currentHealth);
    }
}
