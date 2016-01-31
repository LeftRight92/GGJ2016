using UnityEngine;
using System.Collections;

public class Narrator : MonoBehaviour {

	[SerializeField] private AudioClip[] clips;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		source.clip = clips [0];
		//source.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
