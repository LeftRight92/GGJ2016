using UnityEngine;
using System.Collections;

namespace GGJ2016.Interact {
	public class Door : Interactable {

#pragma warning disable 0649
		[SerializeField]
		private float closeAngle, openAngle;
#pragma warning restore 0649
		[SerializeField]
		private float doorSpeed;
		[SerializeField]
		private bool open, moving;

		// Update is called once per frame
		void Update() {
			if(moving) {
				if(open)
					RotateToward(openAngle);
				else
					RotateToward(closeAngle);
			}
		}

		void RotateToward(float angle) {
			transform.parent.Rotate(Vector3.up, Mathf.Clamp(angle - transform.parent.eulerAngles.y, -doorSpeed, doorSpeed));
			//transform.Rotate(Vector3.up, Mathf.Min(doorSpeed, Mathf.Abs(transform.eulerAngles.y - angle)));
			if(angle == transform.eulerAngles.y) moving = false;
        }

		public override void Interact() {
			StopAllCoroutines();
			moving = true;
			open = !open;
			if(open) StartCoroutine(ShutLater());
		}

		IEnumerator ShutLater() {
			yield return new WaitForSeconds(3.0f);
			moving = true;
			open = false;
		}
	}
}
