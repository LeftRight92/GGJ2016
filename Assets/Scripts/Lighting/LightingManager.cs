using UnityEngine;
using System.Collections;

public class LightingManager : MonoBehaviour {

	[SerializeField] private FlickerLight[] flickerLights;
	[SerializeField] private bool flickerOn;
	[SerializeField] private float flickerPeriod = 0.05f;

	private bool flickerNow = true;

	// Use this for initialization
	void Start () {
		flickerLights = FindObjectsOfType<FlickerLight> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (flickerOn && flickerNow) {
			float amount = Random.value;
			foreach(FlickerLight f in flickerLights) f.FlickerAmount = amount;
			StartCoroutine(FlickerWait());
		}

	}

	public void ToggleFlicker(){
		flickerOn = !flickerOn;
		if (!flickerOn) {
			foreach(FlickerLight f in flickerLights) f.FlickerAmount = 1f;
		}
	}

	IEnumerator FlickerWait(){
		flickerNow = false;
		yield return new WaitForSeconds(flickerPeriod * Random.Range(0.75f,1.25f));
		flickerNow = true;
	}
}
