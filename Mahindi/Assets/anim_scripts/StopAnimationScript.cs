using UnityEngine;
using System.Collections;

public class StopAnimationScript : MonoBehaviour {
	Animator anim;
	int buttonHash = Animator.StringToHash("StopAnimationParam");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void StopAnimationFunction()
	{
		anim.SetTrigger (buttonHash);
	}
}