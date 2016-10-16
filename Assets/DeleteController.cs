using UnityEngine;
using System.Collections;

public class DeleteController : MonoBehaviour {

	
	public GameObject unitychan;

	void Start () {
		unitychan = GameObject.Find("unitychan");
	}

	// Update is called once per frame
	void Update ()
	{
		Debug.Log (unitychan.transform.position.z);
		//Debug.Log(coin.transform.position.z);
		//Debug.Log ("item" + this.gameObject.tag);


		if (this.gameObject.tag == "CoinTag" || this.gameObject.tag == "CarTag" || this.gameObject.tag == "TrafficConeTag") {

			Debug.Log (this.gameObject.tag + this.transform.position.z);
			if (unitychan.transform.position.z > this.transform.position.z) {
				Destroy(this.gameObject);
			}
		}

	}
}

/*
		//Debug.Log (this.transform.position.z);
		coins = GameObject.FindGameObjectsWithTag ("CoinTag");
		foreach (GameObject coin in coins) {
			//Debug.Log(coin.transform.position.z);
			if ((this.transform.position.z -1) > coin.transform.position.z) {
				Destroy(coin);
			}
			 
		}

		trafficCones = GameObject.FindGameObjectsWithTag ("TrafficConeTag");
		foreach (GameObject trafficCone in trafficCones) {
			//Debug.Log(coin.transform.position.z);
			if ((this.transform.position.z -1) > trafficCone.transform.position.z) {
				Destroy(trafficCone);
			}
			 
		}

		cars = GameObject.FindGameObjectsWithTag ("CarTag");
		foreach (GameObject car in cars) {
			//Debug.Log(coin.transform.position.z);
			if ((this.transform.position.z -1) > car.transform.position.z) {
				Destroy(car);
			}
			 
		}
*/