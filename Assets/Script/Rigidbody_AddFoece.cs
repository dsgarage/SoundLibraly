using UnityEngine;
using System.Collections;

public class Rigidbody_AddFoece : MonoBehaviour {

public GameObject bigCube;
public Vector3 bigCubeStartPos;
public Quaternion bigCubeStartRot;

public GameObject smallCube;
public Vector3 smallCubeStartPos;
public Quaternion smallCubeStartRot;


	// Use this for initialization
	void Start () {

	bigCubeStartPos = bigCube.transform.position;
	smallCubeStartPos = smallCube.transform.position;

	bigCubeStartRot = bigCube.transform.rotation;
	smallCubeStartRot = smallCube.transform.rotation;

	bigCube.rigidbody.Sleep();
	smallCube.rigidbody.Sleep();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
	if (GUILayout.Button("Reset")) {
		bigCube.rigidbody.Sleep();
		smallCube.rigidbody.Sleep();
		bigCube.transform.position = bigCubeStartPos;
		smallCube.transform.position = smallCubeStartPos;
		bigCube.transform.rotation = bigCubeStartRot;
		smallCube.transform.rotation = smallCubeStartRot;
	}
	
	Vector3 dir = Vector3.right;

	if (GUILayout.Button("Force")) {
		bigCube.rigidbody.AddForce(dir.normalized * 200f, ForceMode.Force);
		smallCube.rigidbody.AddForce(dir.normalized * 200f, ForceMode.Force);
	}

	if (GUILayout.Button("Acceleration")) {
		bigCube.rigidbody.AddForce(dir.normalized * 200f, ForceMode.Acceleration);
		smallCube.rigidbody.AddForce(dir.normalized * 200f, ForceMode.Acceleration);
	}
	if (GUILayout.Button("Impulse")) {
		bigCube.rigidbody.AddForce(dir.normalized * 10f, ForceMode.Impulse);
		smallCube.rigidbody.AddForce(dir.normalized * 10f, ForceMode.Impulse);
	}
	if (GUILayout.Button("VelocityChange")) {
		bigCube.rigidbody.AddForce(dir.normalized * 10f, ForceMode.VelocityChange);
		smallCube.rigidbody.AddForce(dir.normalized * 10f, ForceMode.VelocityChange);
	}
	}

}
