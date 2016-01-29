using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float time;

	public Slider timeIndicator;

	public BurnLogic burnLogic;

	private float initialTime;

	public float procentage = 1f;

	void Awake() {
		initialTime = time;
	}
	
	// Update is called once per frame
	void Update()
	{

		time -= Time.deltaTime;

		procentage = (time / initialTime);

		timeIndicator.value = procentage;

		if (time <= 0 && burnLogic != null)
		{
            LevelManager.level++;
			burnLogic.burn();
		}

	}
}
