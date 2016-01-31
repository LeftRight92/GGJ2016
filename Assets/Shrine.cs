using UnityEngine;
using System.Collections;
using System.Linq;
using GGJ2016.Lighting;

namespace GGJ2016.Interact{
	public class Shrine : Interactable {
		public override void Interact(){
			GetComponentsInChildren<Light>().ToList().ForEach(l => l.enabled = true);
			GetComponentsInChildren<CandleLight>().ToList().ForEach(l => l.enabled = true);
			RitualManager.instance.NextObjective ();
			this.tag = "Untagged";
		}
	}
}
