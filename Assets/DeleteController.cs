using UnityEngine;
using System.Collections;

public class DeleteController : MonoBehaviour {

	

	public GameObject[] coins;
	public GameObject[] trafficCones;
	public GameObject[] cars;
	void Start () {


	}

	// Update is called once per frame
	void Update ()
	{
		//Debug.Log (this.transform.position.z);
		coins = GameObject.FindGameObjectsWithTag ("CoinTag");
		foreach (GameObject coin in coins) {
			//Debug.Log(coin.transform.position.z);
			if ((this.transform.position.z -1) > coin.transform.position.z) {
				Destroy(coin);
			}
			 
		}

		trafficCones = GameObject.FindGameObjectsWithTag ("TrafficConeTag");
		foreach (GameObject traffiCone in trafficCones) {
			//Debug.Log(coin.transform.position.z);
			if ((this.transform.position.z -1) > traffiCone.transform.position.z) {
				Destroy(traffiCone);
			}
			 
		}

		cars = GameObject.FindGameObjectsWithTag ("CarTag");
		foreach (GameObject car in cars) {
			//Debug.Log(coin.transform.position.z);
			if ((this.transform.position.z -1) > car.transform.position.z) {
				Destroy(car);
			}
			 
		}

	}

}
