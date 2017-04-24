using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D BallCollision){
		print ("Trigged Loose");
		levelManager.LoadLevel("Win Screen");
	}
}
