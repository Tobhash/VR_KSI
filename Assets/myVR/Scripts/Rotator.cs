using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    public float speed;
    public GameObject player;

    private Vector3 pointToRotate;

	// Use this for initialization
	void Start () {
        pointToRotate = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(pointToRotate, Vector3.up, speed * Time.deltaTime);
	}

    public void shutDown() {
        gameObject.SetActive(false);
    }
}
