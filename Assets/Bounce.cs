using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag == "ball") {
			col.gameObject.GetComponent<Rigidbody>().AddForce
				(Vector3.up*10, ForceMode.Impulse);
		}
	}
}    