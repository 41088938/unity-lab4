using UnityEngine;
using System.Collections;

public class Kick : MonoBehaviour {

	public float power = 1;

	void OnControllerColliderHit(ControllerColliderHit hit) {
		print("inside OnControllerColliderHit");
		
		if (hit.gameObject.tag == "ball") {
			print("my current is " + power);
			hit.gameObject.GetComponent<Rigidbody>().AddForceAtPosition
				(GetComponent<CharacterController>().velocity*power,  
				 hit.point,ForceMode.Impulse);
		}
	}
}

