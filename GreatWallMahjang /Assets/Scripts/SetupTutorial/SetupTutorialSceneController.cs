using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetupTutorialSceneController : MonoBehaviour {

MakeAGreatWall wall;
SetupNavigatorScript navi;
ShakeTheDices dices;
GameObject sceneObject,fukidashi,dice1,dice2,missionStamp;
bool firstSeechDone=false;
bool tilesAreOnTheTable=false;
bool afterDices=false;
bool tilesGoToPlayers=false;
bool lastOneTile=false;
bool tilesAreLyingDown=false;
bool setupHasDone=false;
	// Use this for initialization
	void Start () {
		wall=GetComponent<MakeAGreatWall>();
		navi=GetComponent<SetupNavigatorScript>();
		dices=GetComponent<ShakeTheDices>();
		fukidashi=GameObject.Find("Fukidashi");
		dice1=GameObject.Find("Dice1");
		dice2=GameObject.Find("Dice2");
		missionStamp=GameObject.Find("MissionComplete");
		missionStamp.SetActive(false);

		StartCoroutine("startSetupTutorial");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void restartCoroutine(){
		StartCoroutine("startSetupTutorial");
		fukidashi.SetActive(false);
	}
	

	IEnumerator startSetupTutorial(){
		while(firstSeechDone==false)
		{
			yield return navi.firstNavi();
			firstSeechDone=true;
			StopCoroutine("startSetupTutorial");
		}
		while(tilesAreOnTheTable==false)
		{
		
			yield return wall.tilesMakeAGreatWall();
			yield return new WaitForSeconds(7);
			yield return navi.secondNavi();
			tilesAreOnTheTable=true;
			StopCoroutine("startSetupTutorial");
		}
		while(afterDices==false){
			yield return dices.startDices();
			yield return new WaitForSeconds(0.5f);
			dices.controlLights();
			yield return new WaitForSeconds(5f);
			yield return navi.thirdNavi();
			afterDices=true;
			StopCoroutine("startSetupTutorial");
		}
		while(tilesGoToPlayers==false){
			yield return wall.cameraZoomOut();
			yield return wall.cameraXRotationChange();
			dices.returnLights();
			//fukidashi.SetActive(false);
			yield return new WaitForSeconds(4);
			yield return navi.fourthNavi();
			tilesGoToPlayers=true;
			StopCoroutine("startSetupTutorial");
		}
		while(lastOneTile==false){
			
			yield return wall.playersGetTilesForStart();
			Destroy(dice1);
			Destroy(dice2);
			//fukidashi.SetActive(false);
			yield return new WaitForSeconds(7);
			yield return navi.fifthNavi();
			lastOneTile=true;
			StopCoroutine("startSetupTutorial");
		}
		while(tilesAreLyingDown==false)
		{
			
			yield return wall.lastOneTiles();
			//yield return wall.standupTiles();

			//fukidashi.SetActive(false);
			yield return new WaitForSeconds(4);
			yield return navi.sixthNavi();
			tilesAreLyingDown=true;
			StopCoroutine("startSetupTutorial");
		}
		while(setupHasDone==false)
		{
			yield return wall.standupTiles();
			yield return new WaitForSeconds(3);
			missionStamp.SetActive(true);

			setupHasDone=true;

		}
		yield break;
		
		//yield return StartCoroutine(navi.secondNavi());
		
	}
}
