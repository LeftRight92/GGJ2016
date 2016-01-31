using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact{
	public class Bed : Interactable {
		public override void Interact(){
		RitualManager.instance.NextObjective ();
			this.tag = "Untagged";
			}
	}
}