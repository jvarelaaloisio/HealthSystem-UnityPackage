using UnityEngine;

namespace HealthSystem.Runtime.Components.Hazards
{
	[Tooltip("Component that kills anything it triggers")]
	public class KillBound : DamageDealer
	{
		protected void OnTriggerEnter(Collider other) => TryAttack(other);

		private void OnTriggerEnter2D(Collider2D other) => TryAttack(other);

		protected override void Attack(IHealthComponent target) => target.Health.Kill();
	}
}