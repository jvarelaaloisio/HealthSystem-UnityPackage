using System;
using System.Collections.Generic;
using UnityEngine;

namespace HealthSystem.Runtime.Components.Hazards
{
	[Tooltip("Component that can attack overlapping IHealthComponent" +
	         "\nUseful for weapons and enemies")]
	public abstract class Hazard : DamageDealer
	{
		private readonly HashSet<IHealthComponent> _targets = new();

	#region 2D

		protected void OnTriggerEnter2D(Collider2D other) => TryAddTarget(other);

		protected void OnTriggerExit2D(Collider2D other) => TryRemoveTarget(other);

	#endregion

	#region 3D

		protected virtual void OnTriggerEnter(Collider other) => TryAddTarget(other);

		protected virtual void OnTriggerExit(Collider other) => TryRemoveTarget(other);

	#endregion

		public virtual void Attack()
		{
			foreach (var target in _targets)
				Attack(target);
		}

		private void TryAddTarget(Component other)
		{
			if (TryFindHealth(other, out var target))
				_targets.Add(target);
		}

		private void TryRemoveTarget(Component other)
		{
			if (TryFindHealth(other, out var target))
				_targets.Remove(target);
		}
	}
}