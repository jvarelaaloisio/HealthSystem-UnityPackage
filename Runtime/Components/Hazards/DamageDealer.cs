using UnityEngine;

namespace HealthSystem.Runtime.Components.Hazards
{
    public class DamageDealer : MonoBehaviour
    {
        [SerializeField] protected int damage;
		
        /// <summary>
        /// Deals damage to the target
        /// </summary>
        /// <param name="target"></param>
        protected virtual void Attack(IHealthComponent target) => target.TakeDamage(damage);

        /// <summary>
        /// Tries to get the HealthComponent in target. If successful, will call <see cref="Attack"/> on it
        /// </summary>
        /// <param name="target"></param>
        public virtual void TryAttack(Component target)
        {
            if (TryFindHealth(target, out var healthComponent))
                Attack(healthComponent);
            else
                Debug.LogWarning($"{name}: Tried to attack {target.name}, but couldn't find the health component!");
        }

        protected virtual bool TryFindHealth(Component target, out IHealthComponent healthTarget)
        {
            return target.TryGetComponent(out healthTarget);
        }
    }
}