using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            TakeDamage(20);
        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
           HealHealth(20);
        }

        //Pour que la vie n'aille pas en dessous de 0
        if (currentHealth < 0) { currentHealth = 0; }
        //Pour que la vie n'aille pas au dessus de 100
        if (currentHealth > maxHealth) { currentHealth = 100; }

        //Tue le joueur si sa vie atteint 0
        if (currentHealth == 0) { Death(); }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ennemy"))
        {
            TakeDamage(10);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    private void Death()
    {
        this.gameObject.SetActive(false);
    }
    void HealHealth(int damage)
    {
        currentHealth += damage;

        healthBar.SetHealth(currentHealth);
    }
}
