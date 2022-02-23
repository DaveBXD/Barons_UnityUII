using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelaLielums : MonoBehaviour {

	public GameObject attelaTuretajs;
	public GameObject slaideris;

	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1F * pasreizejaVertiba, 1F * pasreizejaVertiba);
	}
}