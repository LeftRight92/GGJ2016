using UnityEngine;
using System.Collections;

public class TVStatic : MonoBehaviour {
	[SerializeField] private Texture[] textures;

	void Start(){
		StartCoroutine (Scroll ());
	}

	IEnumerator Scroll(){
		while (true) {
			foreach(Texture t in textures){
				GetComponent<MeshRenderer>().material.mainTexture = t;
				yield return new WaitForSeconds(0.25f);
			}
		}
	}
}
