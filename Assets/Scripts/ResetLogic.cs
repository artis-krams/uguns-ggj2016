using UnityEngine;
using System.Collections;

public class ResetLogic : MonoBehaviour {

	public GameObject item;
	private GameObject currentItem;

	void Awake() {
		currentItem = (GameObject) GameObject.Instantiate (item, transform.position, transform.rotation);
		currentItem.transform.parent = transform;
	}

	void OnMouseDown() {
		Destroy (currentItem);
		currentItem = (GameObject) GameObject.Instantiate (item, transform.position, transform.rotation);
		currentItem.transform.parent = transform;
	}
}
