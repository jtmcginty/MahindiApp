using UnityEngine;
using System.Collections;

public class AnimateNowScript : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("AnimateNowParam");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void AnimateNowFunction()
	{
		anim.SetTrigger (buttonHash);
	}
}