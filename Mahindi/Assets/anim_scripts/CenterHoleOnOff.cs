using UnityEngine;
using System.Collections;

public class CenterHoleOnOff : MonoBehaviour {
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}

	public void ToggleOnOff () {
		if (rend.enabled == true) rend.enabled = false;
		else rend.enabled = true;
	}
}
