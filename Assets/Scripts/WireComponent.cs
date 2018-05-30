using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireComponent : CircuitComponent {

	public override void generateElectron() {
		// NOTE: "scale" property is in each direction, so need to be careful about where 2x or /2 are necessary
		//float yOffset = transform.position.y + transform.GetComponent<CapsuleCollider>().center.y - transform.GetComponent<CapsuleCollider>().height / 2.0f;
		Transform e = Instantiate(electron, transform.position, transform.rotation, transform);
		e.localScale = new Vector3 (2.0f, 2.0f * transform.localScale.x / transform.localScale.y, 2.0f);
		// hacky, but this is easier than figuring out the correct direction to pull
		e.localPosition = new Vector3 (0.0f, -1.0f, 0.0f);
		e.GetComponent<Rigidbody>().velocity = transform.up * speed;
		// schedule destruction and next component generation
		float timeDelay = 2.0f * transform.localScale.y / speed;
		Invoke("triggerNextCircuitComponent", timeDelay);
		Destroy(e.gameObject, timeDelay);
	}
}
