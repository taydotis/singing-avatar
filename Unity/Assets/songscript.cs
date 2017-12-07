using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songscript : MonoBehaviour {

	public void playAudio () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
	
}
