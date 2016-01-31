using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact{
public class Sink : Interactable {
		public override void Interact ()
		{
			GetComponent<AudioSource> ().Play ();
			RitualManager.instance.NextObjective ();
			this.tag = "Untagged";
		}
	}
}
