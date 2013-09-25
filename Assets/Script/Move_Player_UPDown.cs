using UnityEngine;
using System.Collections;

//Rigidbody強制追加
//[RequireComponent(typeof(Rigidbody))]
public class Move_Player_UPDown : MonoBehaviour 
{

	public float speed = 6.0f;
	public enum MovePattern{
	UPDownMove, UPDownStop
	}

	void Awake()
	{

	//Rigidbody追加.
//	gameObject.AddComponent<Rigidbody>();		
	}

	public void Update()
	{

		// 上下に対応する入力による上下移動 要Rigidbody
//		rigidbody.velocity = new Vector3(0, Input.GetAxisRaw("Vertical") * speed, 0);
		transform.position += new Vector3(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);

	}


}
 