using UnityEngine;
using System.Collections;

public class EnemyMover : MonoBehaviour {

	public float speedMin;
	public float speedMax;
	
	
	enum EnemyState { Normal, Dying};
	
	private EnemyState _state;


	void Start () {
		_state = EnemyState.Normal;
		float thisSpeed = Random.Range(speedMin, speedMax);
		this.GetComponent<Rigidbody>().velocity = transform.forward * thisSpeed;
	}
	
	
	
	public bool IsDying() {
		return (_state == EnemyState.Dying);
	}
	
	
	
	public void DieSoon() {
		if (_state == EnemyState.Normal) {
			
			_state = EnemyState.Dying;
			GameController gameController = FindObjectOfType<GameController>();
			gameController.GotOne();
			this.GetComponent<AudioSource>().Play();
			Destroy(gameObject, 1.5f);
		}
	}

	
	
}

