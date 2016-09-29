using UnityEngine;
using System.Collections;

public class HandPlant : MonoBehaviour {
	public Renderer rend;
	Animator anim;
	int buttonHash = Animator.StringToHash("AnimGo");

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}
	
	public void AnimateNow()
	{
		rend.enabled = true;
		anim.SetTrigger (buttonHash);
	}
}