using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact {
	public class BookDown : Interactable {
		[SerializeField] private GameObject book;

		public override void Interact(){
			book.SetActive (true);
			GetComponent<AudioSource> ().Play ();
			RitualManager.instance.NextObjective ();
			this.tag = "Untagged";
		}
	}
}
