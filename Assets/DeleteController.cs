using UnityEngine;
using System.Collections;

public class DeleteController : MonoBehaviour {

	

	public GameObject[] coins;

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

	}

}
