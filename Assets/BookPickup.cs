using UnityEngine;
using System.Collections;


namespace GGJ2016.Interact {
	public class BookPickup : Interactable {
		public override void Interact(){
			gameObject.SetActive (false);
			RitualManager.instance.NextObjective ();
			this.tag = "Untagged";
		}
	}
}
