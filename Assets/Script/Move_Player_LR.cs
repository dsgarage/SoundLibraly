using UnityEngine;
using System.Collections;

public class Move_Player_LR : MonoBehaviour {

	public float rateX; //Speed
	public float minX; // Move Range
	public float maxY; // Move Range

	// Use this for initialization
	void Start () {
		rateX = 11;
		minX = -11f;
		maxY = 11f;
	}
	
	// Update is called once per frame
	void Update () {

		float incX = 0;

		// Left Button
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			incX -= rateX * Time.deltaTime;
		}

		// Right Button
		if(Input.GetKey(KeyCode.RightArrow))
		{
			incX += rateX * Time.deltaTime;
		}

		Vector3 pos = transform.localPosition;
		pos.x = Mathf.Clamp(pos.x + incX, minX, maxY);
		transform.localPosition = pos;
	
	}
}
