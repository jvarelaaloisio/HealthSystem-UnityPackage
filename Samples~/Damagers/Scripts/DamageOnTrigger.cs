using UnityEngine;

namespace HealthSystem.Runtime.Components.Damagers
{
	public class DamageOnTrigger : DamageDealer
	{
		private void OnTriggerEnter(Collider other) => TryAttack(other);

		private void OnTriggerEnter2D(Collider2D other) => TryAttack(other);
	}
}