﻿using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(PoliceLights))]
public class PoliceLightsInspector : Editor {

	public override void OnInspectorGUI() {
		base.OnInspectorGUI();

		if(GUILayout.Button("Toggle")) {
			((PoliceLights)target).On = !((PoliceLights)target).On;
		}
	}
}