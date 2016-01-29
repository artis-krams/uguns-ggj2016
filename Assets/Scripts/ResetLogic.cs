using UnityEngine;
using System.Collections;

public class ResetLogic : MonoBehaviour
{

    public GameObject item;
    private GameObject currentItem;

    void Awake()
    {
        currentItem = (GameObject)Instantiate(item, transform.position, transform.rotation);
        currentItem.transform.parent = transform;
    }

    void OnMouseDown()
    {
        Debug.Log("wohoo" + LevelManager.level);
        Destroy(currentItem);
        currentItem = (GameObject)Instantiate(item, transform.position, transform.rotation);
        currentItem.transform.parent = transform;
    }
}
