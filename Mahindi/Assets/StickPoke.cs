using UnityEngine;
using System.Collections;

public class StickPoke : MonoBehaviour
{
	public Renderer rend;
	Animator anim;
	int buttonHash = Animator.StringToHash("Poke");

	void Start ()
	{
		anim = GetComponent<Animator>();
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}

	public void StickPokeNow()
	{
		rend.enabled = true;
		anim.SetTrigger (buttonHash);
	}
}