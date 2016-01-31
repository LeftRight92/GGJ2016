using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact{
	public class DoorBasement : Door {
		public override void Interact(){
			base.Interact ();
			StartCoroutine (Disable ());
			RitualManager.instance.NextObjective ();
			this.tag = "Untagged";
		}

		IEnumerator Disable(){
			yield return new WaitForSeconds (1f);
			this.enabled = false;
		}
	}
}