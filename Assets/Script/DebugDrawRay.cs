using UnityEngine;
using System.Collections;

public class DebugDrawRay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 up = transform.TransformDirection(Vector3.up) * 10;
        Debug.DrawRay(transform.position, up, Color.green);
	}

	private void OnCollisionEnter(Collision collision)
	{
//		Destroy(collision.gameObject);
        foreach (ContactPoint contact in collision.contacts) {
            Debug.DrawRay(contact.point, contact.normal, Color.red, 2.0f);
        }
     
	}

}
