using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	private float time;

	public float startTime = 5f;

	public Slider timeIndicator;

	public bool timeEnded = false;

	public BurnLogic burnLogic;

	private float initialTime;

	public float procentage = 1f;

	void Awake() {
		initialTime = startTime / LevelManager.level;
		time = initialTime;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (timeEnded == true) {
			Debug.Log ("destroy object in timer");
			Destroy (gameObject);
		}

		time -= Time.deltaTime;

		procentage = (time / initialTime);

		timeIndicator.value = procentage;

		if (time <= 0 && burnLogic != null)
		{
            LevelManager.level += 0.1f;
			burnLogic.burn();
			timeEnded = true;
		}

	}
}
