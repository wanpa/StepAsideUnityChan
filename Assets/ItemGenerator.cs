using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour {
	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPrefabを入れる
	public GameObject conePrefab;
	//スタート地点
	private int startPos = -160;
	//ゴール地点
	private int goalPos = 120;
	//アイテムを出すx方向の範囲
	private float posRange = 3.4f;
	//ユニティちゃんを入れる
	public GameObject unitychan;

	private float unityPositionZ;

	// Use this for initialization
	void Start () {

		unitychan = GameObject.Find("unitychan");
		//一定の距離ごとにアイテムを生成
		for (int i = startPos; i < goalPos; i+=15) {
			//どのアイテムを出すのかをランダムに設定

		}
	}

	// Update is called once per frame
	void Update () {
		//Unityちゃんのz座標を取得
		this.unityPositionZ = this.unitychan.transform.position.z;

		if (unityPositionZ >= startPos - 50){
			ItemCreat(startPos);
			startPos += 15;
		}
	}

	void ItemCreat (float i){
		if (startPos <= i && i <= goalPos){
			int num = Random.Range (0, 10);
			if (num <= 1) {
				//コーンをx軸方向に一直線に生成
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
				}
			} else {

				//レーンごとにアイテムを生成
				for (int j = -1; j < 2; j++) {
					//アイテムの種類を決める
					int item = Random.Range (1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range (-5, 6);
					//50%コイン配置:30%車配置:10%何もなし
					if (1 <= item && item <= 6) {
						//コインを生成
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
					} else if (7 <= item && item <= 9) {
						//車を生成
						GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
					}
				}

			}
		}
	}
}
