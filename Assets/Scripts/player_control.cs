using UnityEngine;
using System.Collections;

public class player_control : MonoBehaviour {
    
    GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        player.transform.position = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
	}
}
