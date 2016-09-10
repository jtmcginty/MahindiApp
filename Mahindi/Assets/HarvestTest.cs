using UnityEngine;
using System.Collections;

public class HarvestTest : MonoBehaviour
{
	Animator anim;
	int buttonHash = Animator.StringToHash("HarvestPress");

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void AnimateNow()
	{
		anim.SetTrigger (buttonHash);
	}
}