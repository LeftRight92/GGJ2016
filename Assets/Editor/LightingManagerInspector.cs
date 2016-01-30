using UnityEngine;
using UnityEditor;
using System.Collections;

namespace GGJ2016.Lighting {
	[CustomEditor(typeof(LightingManager))]
	public class LightingManagerInspector : Editor {

		public override void OnInspectorGUI() {
			base.OnInspectorGUI();

			if(GUILayout.Button("Toggle Flicker")) {
				((LightingManager)target).ToggleFlicker();
			}
			if(GUILayout.Button("Let there be LIGHTNING!")) {
				((LightingManager)target).DoLightning();
			}
		}
	}
}