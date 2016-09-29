using UnityEngine;
using System.Collections;

public class TargetSwitcher : MonoBehaviour {
public Transform target1;
public Transform target2;
public Transform target3;

public void Switch() {
	JoesScript follower = GetComponent<JoesScript>();
	if (follower == null) Debug.LogError("Hey, where's the JoesScript?!?");

	if (follower.target == target1) follower.target = target2;
	else follower.target = target1;
	}
public void Cam1() {
	JoesScript follower = GetComponent<JoesScript>();
	if (follower == null) Debug.LogError("Hey, where's JoesScript?!?");

	follower.target = target1;
	}
public void Cam2() {
	JoesScript follower = GetComponent<JoesScript>();
	if (follower == null) Debug.LogError("Hey, where's JoesScript?!?");

	follower.target = target2;
	}
public void Cam3() {
	JoesScript follower = GetComponent<JoesScript>();
	if (follower == null) Debug.LogError("Hey, where's JoesScript?!?");

	follower.target = target3;
	}
}
