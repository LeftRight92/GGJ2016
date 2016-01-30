using UnityEngine;
using System.Collections;

namespace GGJ2016.Lighting {
	public class LightningLight : MonoBehaviour {

		private float maxIntensity;
		private new Light light;

		// Use this for initialization
		void Start() {
			light = GetComponent<Light>();
			maxIntensity = light.intensity;
			light.intensity = 0f;
		}

		public void DoLightning(float length) {
			StartCoroutine(Lightning(length));
		}

		IEnumerator Lightning(float length) {
			light.intensity = maxIntensity;
			yield return new WaitForSeconds(length);
			light.intensity = 0f;
		}
	}
}