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

		public void DoLightning() {
			StartCoroutine(Lightning());
		}

		IEnumerator Lightning() {
			light.intensity = maxIntensity;
			yield return new WaitForSeconds(0.05f);
			light.intensity = 0f;
			yield return new WaitForSeconds(0.05f);
			light.intensity = maxIntensity;
			yield return new WaitForSeconds(0.05f);
			light.intensity = 0f;
			yield return new WaitForSeconds(0.15f);
			light.intensity = maxIntensity * 0.5f;
			yield return new WaitForSeconds(0.05f);
			light.intensity = 0f;
		}
	}
}