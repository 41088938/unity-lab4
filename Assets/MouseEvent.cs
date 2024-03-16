using UnityEngine;
using System.Collections;

public class MouseEvent : MonoBehaviour {

	float range = 0.05f;
	float factor;
	Vector3 oriScale;

	void Start () {
		oriScale = transform.localScale;
	}

	void OnMouseOver () {
		factor = Mathf.Sin(Time.time*10)*range;
		transform.localScale = new Vector3(oriScale.x+factor,
		                                   oriScale.y+factor,
		                                   oriScale.z+factor);
	}

	void Update()
	{
		if (Input.GetKey("up"))
			transform.Translate(Vector3.forward * 0.1f);
		if (Input.GetKey("down"))
			transform.Translate(Vector3.forward * -0.1f);
		if (Input.GetKey("left"))
			transform.Rotate(Vector3.up * -2);
		if (Input.GetKey("right"))
			transform.Rotate(Vector3.up * 2);

	}


}