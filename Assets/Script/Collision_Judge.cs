using UnityEngine;
using System.Collections;

public class Collision_Judge : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
	//衝突範囲に侵入
	}

	void OnCollisionStay(Collision collision){
	//衝突範囲内のまま移動
	}

	void OnCollisionExit(Collision collision){
	//衝突範囲から離れた
	}

	void OnTriggerEnter(Collision collision){
	//接触範囲に侵入
	}

	void OnTriggerStay(Collision collision){
	//接触範囲内のまま移動
	}
	
	void OnTriggerExit(Collision collision){
	//接触範囲から離れた
	}

}
