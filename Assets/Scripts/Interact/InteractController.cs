using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact {
	public class InteractController : MonoBehaviour {

		[SerializeField]
		private float distance = 1f;
		// Use this for initialization
		void Start() {

		}

		// Update is called once per frame
		void Update() {
			if(Input.GetButtonDown("Interact")) {
				RaycastHit hit;
				if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance) &&
					hit.collider.transform.tag == "Interactable") {
					hit.collider.GetComponent<Interactable>().Interact();
				}
			}
		}
	}
}
