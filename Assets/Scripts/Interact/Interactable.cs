using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact {
	public class Interactable : MonoBehaviour {
		void Start() {
			Debug.LogError("Base Class - Extend from this");
		}
		public virtual void Interact() {
			Debug.LogError("Base Class - Extend from this");
		}
	}
}
