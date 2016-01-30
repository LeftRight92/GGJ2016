using UnityEngine;
using System.Collections;

public class CandleLight : MonoBehaviour {

	[SerializeField]
	private float flickerSpeed = 10f;
	[Range(0f, 1f)]
	[SerializeField]
	private float minMultiplier = 0.25f;
	private new Light light;
	private float maxIntensity;

	// Use this for initialization	  
	void Start() {					  
		light = GetComponent<Light>();
		maxIntensity = light.intensity;
	}

	// Update is called once per frame
	void Update() {
		light.intensity = Mathf.Lerp(light.intensity, Random.Range(minMultiplier * maxIntensity, maxIntensity), flickerSpeed * Time.deltaTime);
	}
}
