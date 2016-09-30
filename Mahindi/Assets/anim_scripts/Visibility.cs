using UnityEngine;
using System.Collections;

public class Visibility : MonoBehaviour {
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}
	
	public void ShowNow()
	{
		rend.enabled = true;
	}
	public void HideNow()
	{
		rend.enabled = false;
	}
}
