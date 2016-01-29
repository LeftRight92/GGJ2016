using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Light))]
public class FlickerLight : MonoBehaviour {

	[SerializeField]private float intensity = 1f;
	[Range(0f,1f)] public float flickerAmount = 1f;

	// Use this for initialization
	void Start () {
		intensity = GetComponent<Light> ().intensity;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Light> ().intensity = flickerAmount * intensity;
	}
}
