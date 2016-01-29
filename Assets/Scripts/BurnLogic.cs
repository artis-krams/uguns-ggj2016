using UnityEngine;
using System.Collections;

public class BurnLogic : MonoBehaviour
{
    public GameObject Fire;

    private int FireStrength = 1;
    private int Score = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void burn(bool isBad = false)
    {
        Score += isBad ? 1 : -1;
    }
}
