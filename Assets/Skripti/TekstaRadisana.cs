using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaRadisana : MonoBehaviour {

	public string teksts;

	public GameObject ievadesLauks;
	public GameObject VecumsLauks;
	public int vecums = 0;
	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		vecums = int.Parse(VecumsLauks.GetComponent<Text> ().text);
		tekstaAttelosanasLauks.GetComponent<Text> ().text = " Várds "+teksts.ToUpper()+" Vecums "+vecums;
	}
}