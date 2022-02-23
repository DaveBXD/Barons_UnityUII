using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursorsuzattela : MonoBehaviour {

	public AudioSource skanasavots;
	public AudioClip skanaKoAtskanot;

	public void uzbiditsUzAttela(){
		skanasavots.PlayOneShot (skanaKoAtskanot);
		print ("skan");
	}

	public void nobiditsNoAttela(){
		skanasavots.Stop ();
		print ("Beidz skanet");
	}
}

