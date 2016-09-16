using UnityEngine;
using System.Collections;

public class YouLoseIfEnemyHitsThis : MonoBehaviour {

	public GameController gameController;
	
	
	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "Enemy") {
			EnemyMover badGuy = other.gameObject.GetComponent<EnemyMover>();
			if (!badGuy.IsDying()) {
				gameController.GameOver(false);
			}
		}
	}	

}
