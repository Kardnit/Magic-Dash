using UnityEngine;
using System.Collections;

namespace MoreMountains.CorgiEngine
{
	/// <summary>
	/// Gives mana to the player who collects it
	/// </summary>
	[AddComponentMenu("Corgi Engine/Items/Mana Orb")]
	public class ManaOrb : PickableItem
	{
		/// the amount of mana to give the player when collected
		[Tooltip("the amount of mana to give the player when collected")]
		public int ManaToGive = 5;

		/// <summary>
		/// What happens when the object gets picked
		/// </summary>
		protected override void Pick(GameObject picker)
		{
            ManaWeapon.manaCount = ManaWeapon.manaCount + ManaToGive;
		}
	}
}