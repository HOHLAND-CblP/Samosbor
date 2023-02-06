using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Components
{
    public interface IHealth
    {
        float Health { get; }
        float MaxHealth { get; }

        void AddHealth(float amount, bool additive);
        void RemoveHealth(float amount);
        bool IsDead { get; }
    }
}