using UnityEngine;
using System.Collections;

namespace GGJ2016.Lighting {
	[RequireComponent(typeof(Light))]
	public class FlickerLight : MonoBehaviour {

		[SerializeField]
		private float intensity = 1f;

		private float flickerAmount;
		public float FlickerAmount {
			get {
				return flickerAmount;
			}
			set {
				flickerAmount = value;
				GetComponent<Light>().intensity = flickerAmount * intensity;
			}
		}

		// Use this for initialization
		void Start() {
			intensity = GetComponent<Light>().intensity;
		}
	}
}