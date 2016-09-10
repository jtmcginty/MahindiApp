using UnityEngine;
using System.Collections;

public class CornGrowTest : MonoBehaviour
{
	Animator anim;
	int buttonHash = Animator.StringToHash("ButtonPress");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void AnimateNow()
	{
		anim.SetTrigger (buttonHash);
	}
}