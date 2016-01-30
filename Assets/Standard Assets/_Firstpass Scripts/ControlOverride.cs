using UnityEngine;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;

namespace GGJ2016 {
	public class ControlOverride : MonoBehaviour {

		public bool overriden;

		private Dictionary<string, float> overridenValues;
		public Vector3 destination;

		// Use this for initialization
		void Start () {
			overridenValues = new Dictionary<string, float> ();
			overridenValues.Add ("Horizontal", 0f);
			overridenValues.Add ("Vertical", 0f);
			overridenValues.Add ("Mouse X", 0f);
			overridenValues.Add ("Mouse Y", 0f);

		}
		
		// Update is called once per frame
		void Update () {
			if (overriden && destination == Vector3.zero) {
				//do stuff
				if(true){ //destination is reached 
					overriden = false;
					destination = Vector3.zero;
				}
			}
		}

		public float GetAxis(string name){
			if(!overriden) return CrossPlatformInputManager.GetAxis (name);
			return overridenValues[name];
		}

		public void SetTarget(Vector3 destination){
			overriden = true;
			this.destination = destination;
		}

	}
}
