
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class quitter : MonoBehaviour
{


	private float lastClick = 0;

	void Start() {}
	void Update() {}
	public void Quit()
	{
		lastClick = Time.time;	
		if (Time.time - lastClick < 0.3) {
			
			Application.Quit ();
		}
	}
}
