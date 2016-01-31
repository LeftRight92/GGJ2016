using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GGJ2016.Interact;

public class RitualManager : MonoBehaviour {

	[SerializeField]private PromptManager prompt;
	public static RitualManager instance { get; private set; }
	[SerializeField]private int state = 0;
	public GameObject shrine;
	public GameObject TV;
	public GameObject bookPickup;
	public GameObject bookDown;
	public GameObject sink;
	public GameObject basementDoor;
	public GameObject bed;
	public string nextLevel;

	// Use this for initialization
	void Start () {
		instance = this;
		prompt.ShowNext ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NextObjective(){
		prompt.ShowNext ();
		state++;
		switch(state){
		case 1:
			shrine.tag = "Interactable";
			break;
		case 2:
		case 3:
			bookPickup.tag = "Interactable";
			break;
		case 4:
			bookDown.tag = "Interactable";
			break;
		case 5:
			sink.tag = "Interactable";
			break;
		case 6:
			basementDoor.tag = "Interactable";
			break;
		case 7:
			bed.tag = "Interactable";
			break;
		case 8:
			//SOMETHING!
			//Application.LoadLevel(nextLevel);
			break;
		case 9:
			Debug.LogError ("Bad state value");
			break;
		}
	}
}
