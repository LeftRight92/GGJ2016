using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(LightningLight))]
public class LightningLightInspector : Editor {

	public override void OnInspectorGUI ()
	{
		base.OnInspectorGUI ();

		if (GUILayout.Button ("Let there be LIGHTNING!")) {
			((LightningLight) target).DoLightning();
		}
	}
}
