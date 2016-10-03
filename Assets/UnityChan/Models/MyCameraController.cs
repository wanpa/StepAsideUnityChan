using UnityEngine;
using System.Collections;

public class MyCameraController : MonoBehaviour {
	//ユニティちゃんのオブジェクト
	private GameObject unitychan;
	//ユニティちゃんとのカメラの距離
	private float difference;

	// Use this for initialization
	void Start () {
		//ユニティちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//ユニティちゃんとカメラ位置（z座標）の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;
	
	}
	
	// Update is called once per frame
	void Update () {
		//ユニティちゃんの位置いあわせてカメラ位置を移動
		this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);	
	}
}
