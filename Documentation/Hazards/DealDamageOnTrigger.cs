using System;
using UnityEngine;

namespace HealthSystem.Runtime.Components.Hazards
{
	public class DealDamageOnTrigger : DamageDealer
	{
		private void OnTriggerEnter(Collider other) => TryAttack(other);

		private void OnTriggerEnter2D(Collider2D other) => TryAttack(other);
	}
}