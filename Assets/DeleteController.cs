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
		if (this.gameObject.tag == "CoinTag" || this.gameObject.tag == "CarTag" || this.gameObject.tag == "TrafficConeTag") {
			if ((unitychan.transform.position.z-1) > this.transform.position.z) {
				Destroy(this.gameObject);
			}
		}
	}
}