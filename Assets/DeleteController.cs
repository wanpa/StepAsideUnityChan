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