using UnityEngine;
using System.Collections;

public class JoesScript : MonoBehaviour {
	public Transform target;
	public float smoothTime = 0.3f;
	public Transform aimTarget;
	private Vector3 velocity = Vector3.zero;
	void Update() {
		transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime);
		transform.LookAt(aimTarget);
	}
}