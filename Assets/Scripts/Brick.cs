using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	private static int number;

	// Use this for initialization
	void Start () {
		number ++;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		this.timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionExit2D(Collision2D coll) {
		this.timesHit++;
		if(this.timesHit == this.maxHits){
			Destroy(gameObject);
			number--;
		};
		if(number == 0){
			this.winLevel ();
		};
	}

	public void winLevel(){
		Debug.Log("Winning");
		this.levelManager.LoadNextLevel();
	}
}
