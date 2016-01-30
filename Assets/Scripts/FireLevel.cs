using UnityEngine;
using System.Collections;

public class FireLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.localScale = new  Vector3(1,1, LevelManager.level);

    }
}
