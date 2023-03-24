using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthbarSprite;
    [SerializeField] private float reduceSpeed = 2;
    private float target = 1;

 
    // Start is called before the first frame update
    void Start()
    {

    }
   
    public void UpdateHealthBar(float _maxHealth, float _currentHealth)
    {
        _healthbarSprite.fillAmount = _currentHealth / _maxHealth;
    }

    void Update()
    {
        //_healthbarSprite.fillAmount = Mathf.MoveTowards(_healthbarSprite.fillAmount, target, reduceSpeed * Time.deltaTime);
 
    }

    }

