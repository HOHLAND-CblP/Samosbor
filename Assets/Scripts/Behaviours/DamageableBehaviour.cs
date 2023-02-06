using Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthComponent))]
public class DamageableBehaviour : MonoBehaviour, IDamageBehaviour
{
    private IHealth health;

    private void Awake()
    {
        health = GetComponent<IHealth>();
    }

    public void Damage(int amount)
    {
        health.RemoveHealth(amount);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Projectile"))
        {
            health.RemoveHealth(1);
        }
    }
}
