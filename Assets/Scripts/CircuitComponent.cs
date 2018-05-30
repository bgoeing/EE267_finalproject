using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircuitComponent : MonoBehaviour {
	/*private GameObject electronObject = (Transform) Resources.Load("Electron"); 
	protected Transform electron = electronObject.transform;*/
	public Transform electron; // unfortunately still have to set for all...
	protected float electronsPerSecond = 4.0f;
	protected float speed = 2.0f;
	public CircuitComponent nextCircuitComponent = null; // public so we can set it as we set up scene

	public abstract void generateElectron (); // require that each circuit component has a way to generate an electron

	public void triggerNextCircuitComponent() {
		if (nextCircuitComponent != null) {
			nextCircuitComponent.generateElectron ();
		}
	}
}
