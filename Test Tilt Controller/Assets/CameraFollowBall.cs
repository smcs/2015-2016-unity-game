using UnityEngine;
using System.Collections;

public class CameraFollowBall : MonoBehaviour {
	public GameObject player;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.transform.position.x +1, player.transform.position.y +1, player.transform.position.z +1);
	}
}
