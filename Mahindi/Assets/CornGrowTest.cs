using UnityEngine;
using System.Collections;

public class CornGrowTest : MonoBehaviour
{
	public Renderer rend;
	Animator anim;
	int buttonHash = Animator.StringToHash("ButtonPress");

	void Start ()
	{
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