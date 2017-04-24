using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	
	public static MusicPlayer instance = null;

	void Awake () {
		Debug.Log("Music Player awake" + GetInstanceID());
		if(instance != null){
			Destroy(gameObject);
		}else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}


	// Use this for initialization
	void Start () {
		Debug.Log ("Music Player Start" + GetInstanceID());
	}

	// Update is called once per frame
	void Update () {
	
	}
}
