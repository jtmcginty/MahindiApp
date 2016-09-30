using UnityEngine;
using System.Collections;

public class MakeHole : MonoBehaviour {

	public void PrintEvent(string s)
	{
		Debug.Log("PrintEvent: " + s + " called at: " + Time.time);
	}
}
