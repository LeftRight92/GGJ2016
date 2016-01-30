using UnityEngine;
using System.Collections;

namespace GGJ2016.Lighting {
	public class PoliceLights : MonoBehaviour {

		private bool on, isRunning;
		public bool On {
			get {
				return on;
			}
			set {
				on = value;
				if(on && !isRunning) StartCoroutine(Lights());
			}
		}
		[SerializeField]
		private float maxIntensity = 1.0f;
		private float intensity;
		[SerializeField]
		private bool fadeOut;
		[SerializeField]
		private float fadeSpeed = 0.4f;
#pragma warning disable 0649
		[SerializeField]
		private Light leftLight, rightLight;
#pragma warning restore 0649

		// Use this for initialization
		void Start() {
			leftLight.intensity = 0f;
			rightLight.intensity = 0f;
			intensity = maxIntensity;
		}

		void Update() {
			if(fadeOut) {
				intensity -= fadeSpeed * Time.deltaTime;
				if(intensity <= 0) {
					StopAllCoroutines();
					fadeOut = false;
					intensity = maxIntensity;
					on = false;
					isRunning = false;
				}
			}
		}

		IEnumerator Lights() {
			isRunning = true;
			while(on) {
				yield return Flash(leftLight);
				yield return Flash(rightLight);
			}
			isRunning = false;
		}

		IEnumerator Flash(Light light) {
			for(int x = 0; x < 3; x++) {
				light.intensity = intensity;
				yield return new WaitForSeconds(0.05f);
				light.intensity = 0f;
				yield return new WaitForSeconds(0.05f);
			}
		}
	}
}