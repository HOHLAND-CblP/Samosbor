using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Components
{
    public class HealthComponent : MonoBehaviour, IHealth
    {
        [SerializeField] private float health = 100;
        [SerializeField] private float maxHealth = 100;

        public UnityEvent<float> healthEvnt = new UnityEvent<float>();

        public float Health => health;
        public float MaxHealth => MaxHealth;
        public bool IsDead => health <= 0;


        public void Start()
        {
            
        }

        public void AddHealth(float amount, bool additive = true)
        {
            if (additive)
                health += amount;
            else
                health = amount;

            healthEvnt.Invoke(health);
        }

        public void RemoveHealth(float amount)
        {
            health -= amount;
        }
    }
}