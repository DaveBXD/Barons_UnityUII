using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelaTuretajs : MonoBehaviour {
	
	public GameObject attelaTuretajss;
	public Sprite[] attelumasivs;



	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attelaTuretajss.GetComponent<Image> ().sprite = attelumasivs [0];

		else  if (skaitlis == 1)
			attelaTuretajss.GetComponent<Image> ().sprite = attelumasivs [1];

	

	}
}

