using UnityEngine;
using System.Collections;

public class Narrator : MonoBehaviour {

	[SerializeField] private AudioClip[] clips;
	private AudioSource source;
	private int index = 0;
	private bool playNext = true;


	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		source.clip = clips [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (playNext)
			StartCoroutine (Play());
	}

	IEnumerator Play(){
		playNext = false;
		source.clip = clips [index];
		source.Play ();
		yield return new WaitForSeconds(clips[index].length + 2f);
		index++;
		if(index < clips.Length) playNext = true;
	}
}
