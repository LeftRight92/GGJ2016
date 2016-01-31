using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PromptManager : MonoBehaviour {

	[SerializeField] private string[] textPrompts;
	private int index = 0;
	private Text text;
	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ShowNext(){
		Color c = text.color;
		c.a = 1;
		text.color = c;
		text.text = textPrompts [index];
		index ++;
		StartCoroutine (Fade ());
	}

	IEnumerator Fade(){
		yield return new WaitForSeconds(5.0f);
		while (text.color.a > 0) {
			Color c = text.color;
			c.a -= Time.deltaTime * 1;
			text.color = c;
			yield return null;
		}
		Debug.Log ("Done");
	}
}
