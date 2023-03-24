using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 3;
    private float currentHealth;

    [SerializeField] public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.UpdateHealthBar(maxHealth, currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {

            if(collision.gameObject.CompareTag("Bullet"))
            {
                currentHealth--;
                Destroy(collision.gameObject);
                if(currentHealth <= 0)
                {
                    Debug.Log("Player Died");
                    Destroy(collision.gameObject);
                }
                else
                {
                    healthBar.UpdateHealthBar(maxHealth, currentHealth);
                    Destroy(collision.gameObject);
                }
            }
        }
}
