using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact{
	public class kettle : Interactable {
		public override void Interact(){
			GetComponent<AudioSource> ().Play ();
			RitualManager.instance.NextObjective ();
			this.tag = "Untagged";
		}
	}
}
