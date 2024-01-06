using UnityEngine;

namespace HealthSystem.Runtime.Components.Damagers
{
    public class DamageOnCollision : DamageDealer
    {
        private void OnCollisionEnter(Collision collision) => TryAttack(collision.collider);

        private void OnCollisionEnter2D(Collision2D collision) => TryAttack(collision.collider);
    }
}
