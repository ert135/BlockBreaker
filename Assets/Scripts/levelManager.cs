using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel(string level){
		Brick.breakableCount = 0;
		Application.LoadLevel(level);
	}

	public void LoadNextLevel(){
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void BrickDestroyed(){
		if(Brick.breakableCount <= 0 ){
			this.LoadNextLevel();
		}
	}
}
