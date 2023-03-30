using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour
{
    private float topBound = 15;
    private float lowerBound = -400;

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
            if (transform.position.z > topBound)
            {

                currentHealth--;
                Destroy(gameObject);
                if(currentHealth <= 0)
                {
                    SceneManager.LoadScene("Game Over");
                }
                else
                {
                    //healthBar.UpdateHealthbar(maxHealth, currentHealth);
                }
            }
            else if (transform.position.z < lowerBound)
            {
                Destroy(gameObject);
            }
    }
}
