using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public double time;

	public BurnLogic burnLogic;
	
	// Update is called once per frame
	void Update()
	{

		time -= Time.deltaTime;

		if (time <= 0) {
			burnLogic.burn();
		}

	}
}
