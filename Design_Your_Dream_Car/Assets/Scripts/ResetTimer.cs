using UnityEngine;
using System.Collections;

public class ResetTimer : MonoBehaviour {

	private float timer;


	// Use this for initialization
	void Start () {
		timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (Input.touchCount > 0) {
			timer = 0f;
		}

		if (timer > 60f) {
			Application.LoadLevel(0);;
		}
	}
}
