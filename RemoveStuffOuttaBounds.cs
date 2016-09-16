using UnityEngine;
using System.Collections;

public class RemoveStuffOuttaBounds : MonoBehaviour {

	

	void OnTriggerExit (Collider other) 
	{
		Destroy(other.gameObject);
	}
}

