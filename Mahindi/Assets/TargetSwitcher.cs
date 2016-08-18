using UnityEngine;
using System.Collections;

public class TargetSwitcher : MonoBehaviour {
public Transform target1;
public Transform target2;

public void Switch() {
	JoesScript follower = GetComponent<JoesScript>();
	if (follower == null) Debug.LogError("Hey, where's the ExampleClass?!?");

	if (follower.target == target1) follower.target = target2;
	else follower.target = target1;
	}
}
