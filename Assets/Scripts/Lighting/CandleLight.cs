using UnityEngine;
using System.Collections;

namespace GGJ2016.Lighting {
	public class CandleLight : MonoBehaviour {

		[SerializeField]
		private float flickerSpeed = 10f;
		[SerializeField]
		private float flickerDistance = 0.01f;
		[Range(0f, 1f)]
		[SerializeField]
		private float minMultiplier = 0.25f;
		private new Light light;
		private float maxIntensity;
		private Vector3 originalPosition;
		private bool newPosition = true;

		// Use this for initialization	  
		void Start() {
			light = GetComponent<Light>();
			maxIntensity = light.intensity;
			originalPosition = transform.position;
		}

		// Update is called once per frame
		void Update() {
			light.intensity = Mathf.Lerp(light.intensity, Random.Range(minMultiplier * maxIntensity, maxIntensity), flickerSpeed * Time.deltaTime);
			//transform.position = originalPosition + (new Vector3(Random.value, Random.value, Random.value) * flickerDistance);
			if (newPosition)
				StartCoroutine (Move ());
		}

		IEnumerator Move(){
			newPosition = false;
			Vector3 nextPosition = new Vector3 (Random.value - 0.5f, Random.value - 0.5f, Random.value - 0.5f);
			nextPosition *= flickerDistance;
			nextPosition += originalPosition;
			float time = Random.Range (0.01f, 0.1f);
			while (time > 0) {
				transform.position = Vector3.Lerp (transform.position, nextPosition, 0.25f);
				time -= Time.deltaTime;
				yield return null;
			}
			newPosition = true;
		}
	}
}
