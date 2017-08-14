using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTheDices : MonoBehaviour {

	GameObject d1,d2,directionalLight,spotLight,fukidashi;
	// Use this for initialization
	void Start () {
		d1=GameObject.Find("Dice1");
		d2=GameObject.Find("Dice2");
		directionalLight=GameObject.Find("Directional Light");
		spotLight=GameObject.Find("Spotlight");
		fukidashi=GameObject.Find("Fukidashi");
		/*
		Invoke("startDices",4f);
		Invoke("controlLights",4.5f);
		Invoke("returnLights",8f);
		Invoke("invisibleDices",8.5f);
		Invoke("playGameLight",18f);
		 */
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator startDices(){
		yield return new WaitForSeconds(0.1f);
		fukidashi.SetActive(false);
		d1.GetComponent<Rigidbody>().useGravity=true;
		d1.transform.GetComponent< Rigidbody >().angularVelocity = new Vector3(5,5,5);
		d1.transform.GetComponent< Rigidbody >().velocity = new Vector3(2,0,0);

		d2.GetComponent<Rigidbody>().useGravity=true;
		d2.transform.GetComponent< Rigidbody >().angularVelocity = new Vector3(3,4,-2);
		d2.transform.GetComponent< Rigidbody >().velocity = new Vector3(-3,0,-4);
	}

	public void controlLights(){
		directionalLight.GetComponent<Light>().intensity=0.5f;
		spotLight.GetComponent<Light>().enabled=true;
	}

	public void returnLights(){
		directionalLight.GetComponent<Light>().intensity=1.0f;
		//spotLight.GetComponent<Light>().enabled=false;
	}

	public void invisibleDices(){
		d1.SetActive(false);
		d2.SetActive(false);
	}

	public void playGameLight(){
		spotLight.GetComponent<Light>().range=100f;
		spotLight.GetComponent<Light>().spotAngle=179f;
		spotLight.GetComponent<Light>().intensity=0.5f;
	}
}
