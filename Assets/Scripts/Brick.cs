using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;
	public static int breakableCount = 0;

	private int timesHit;
	private LevelManager levelManager;
	private static int number;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		this.isBreakable = (this.tag == "Breakable");

		if(isBreakable){
			breakableCount++;
		}

		levelManager = GameObject.FindObjectOfType<LevelManager>();
		this.timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionExit2D(Collision2D coll) {
		bool isBreakable = (this.tag == "Breakable");
		if(isBreakable){
			this.HandleHits();
		}
	}

	void HandleHits(){
		this.timesHit++;
		int maxHits = hitSprites.Length + 1;
		if(this.timesHit == maxHits){
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy(gameObject);
			number--;
		}else{
			LoadSprites();
		};
	}

	private void LoadSprites() {
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
}
