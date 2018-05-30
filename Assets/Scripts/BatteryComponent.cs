using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryComponent : CircuitComponent {

	// simply tells next component to generate electrons
	public override void generateElectron() {
		triggerNextCircuitComponent ();
	}

	void Start () {
		// spit out electrons
		InvokeRepeating ("generateElectron", 1.0f / electronsPerSecond, 1.0f / electronsPerSecond);
	}
}
