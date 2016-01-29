using UnityEngine;
using System.Collections;

public class ResetLogic : MonoBehaviour {

	private bool mouseEntered;

	void Update () {

		if (mouseEntered == true && Input.GetMouseButtonDown (0)) {
			//TODO: logic goes here
		}
	}

	void OnMouseEnter() {
		mouseEntered = true;
	}

	void OnMouseExit() {
		mouseEntered = false;
	}
}
