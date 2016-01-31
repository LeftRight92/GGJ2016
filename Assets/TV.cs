using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact{
	public class TV : Interactable {
		public GameObject TVShow;
		public override void Interact(){	
			TVShow.SetActive (true);
			RitualManager.instance.NextObjective ();
			this.tag = "Untagged";
		}
	}
}
