using UnityEngine;
using System.Collections;

public class LightingManager : MonoBehaviour {

	[SerializeField]
	private float flickerPeriod = 0.05f;
	[SerializeField]
	private FlickerLight[] flickerLights;
	private bool flickerOn;

	[SerializeField]
	private LightningLight[] lightningLights;

	private bool flickerNow = true;

	// Use this for initialization
	void Start() {
		flickerLights = FindObjectsOfType<FlickerLight>();
		lightningLights = FindObjectsOfType<LightningLight>();
	}

	// Update is called once per frame
	void Update() {
		if(flickerOn && flickerNow) {
			float amount = Random.value;
			foreach(FlickerLight f in flickerLights) f.FlickerAmount = amount;
			StartCoroutine(FlickerWait());
		}

	}

	public void ToggleFlicker() {
		flickerOn = !flickerOn;
		if(!flickerOn) {
			foreach(FlickerLight f in flickerLights) f.FlickerAmount = 1f;
		}
	}

	IEnumerator FlickerWait() {
		flickerNow = false;
		yield return new WaitForSeconds(flickerPeriod * Random.Range(0.75f, 1.25f));
		flickerNow = true;
	}

	public void DoLightning() {
		foreach(LightningLight l in lightningLights) l.DoLightning();
	}
}
