using System;
using UnityEngine;

namespace HealthSystem.Runtime
{
    public interface IHealthComponent
    {
        event Action<IHealthComponent> OnDeath;
        GameObject gameObject { get; }
        Health Health { get; }
        int MaxHp { get; set; }
        int InitialHp { get; set; }
        bool CanOverFlowHp { get; set; }
        void TakeDamage(int damage);
    }
}