using UnityEngine;
using System.Collections;

public class Camera_Move : MonoBehaviour {

	public GameObject target;	// オブジェクト
	public float radius = 15.0f;	// オブジェクトからカメラまでの距離(円運動の半径)
	public float angle = 0.0f;	// ラジアン値
 
	public void Start()
	{
//		target = GameObject.Find("Floor"); // オブジェクトをセット
	}
 
	public void Update()
	{
		Vector3 pos = target.transform.position;
		transform.LookAt(pos);	// カメラをtargetの方向へ向かせるように設定する
 
		// オブジェクトの周りをカメラが円運動する
		transform.position = new Vector3(pos.x + Mathf.Cos(angle) * radius, pos.y + 15, pos.z + Mathf.Sin(angle) * radius);
		angle += 0.01f;
	}

}
