using UnityEngine;
using System.Collections;

public class CenterPlainOnOff : MonoBehaviour {
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}

	public void ToggleOnOff () {
		if (rend.enabled == true) rend.enabled = false;
		else rend.enabled = true;
	}
}
