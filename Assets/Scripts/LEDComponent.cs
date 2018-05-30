using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDComponent : CircuitComponent {

	private Color emissiveColor = Color.yellow;

	// calculate emission and pass on to next
	public override void generateElectron() {
		Component[] renderers;
		renderers = transform.GetComponentsInChildren(typeof(Renderer));
		foreach (Renderer r in renderers) {
			r.material.SetColor ("_EmissionColor", emissiveColor * Mathf.Max (electronsPerSecond / 10.0f, 1.0f));
		}
		triggerNextCircuitComponent ();
	}
}
