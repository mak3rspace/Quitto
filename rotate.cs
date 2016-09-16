using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	float rotationSpeed = 8.0f;
	void rorate()
	{
		this.GetComponent<Rigidbody>().angularVelocity = this.transform.forward * rotationSpeed;
	}

}