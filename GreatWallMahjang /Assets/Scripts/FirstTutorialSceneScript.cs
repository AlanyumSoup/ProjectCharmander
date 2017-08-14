using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstTutorialSceneScript : MonoBehaviour {

	GameObject navigation;
	GameObject MissonStamp;
	GameObject west2;
	Text message;
	
	// Use this for initialization
	void Start () {

		west2=GameObject.Find("15");
		MissonStamp=GameObject.Find("MISSIONCOMPLETE");
		MissonStamp.SetActive(false);

		navigation=GameObject.Find("Text");
		message=navigation.GetComponentInChildren<Text>();

		Invoke("secondText",3f);
		Invoke("moveATile",3f);
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void secondText(){
		message.text="Touch a tile!";
	}

	public void moveATile(){
		iTween.MoveTo(west2,iTween.Hash("x",568f,"time",2f,"easetype",iTween.EaseType.easeOutSine));
	}

	public void touchCorrectTile(){
		message.text="Correct!!";
		Invoke("missionComplete",2f);
		Invoke("backToTopTutorial",4f);


	}

	public void touchWrongTile(){
		message.text="Wrong!!";
		Invoke("secondText",1f);
	}

	public void missionComplete(){
		MissonStamp.SetActive(true);
		

	}

	public void backToTopTutorial(){
		SceneManager.LoadScene("TutorialScene");
	}
}
