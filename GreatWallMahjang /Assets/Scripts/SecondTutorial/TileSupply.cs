using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSupply : MonoBehaviour {

//public bool thereIsATile=false;
	// Use this for initialization
	void Start () {
		Invoke("supplyATile",3.5f);
		//supplyATile();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void supplyATile(){
		int random = Random.Range(1,145);
		Debug.Log(random+" Test");
		GameObject tempObj= GameObject.Find(random.ToString());
		bool _onTheBoard= tempObj.GetComponent<TileAsset>().onTheBoard;
		if(_onTheBoard==false)
		{
			
			iTween.MoveTo(tempObj,iTween.Hash("position",new Vector3(0,0,0),"time",0.2f));
			tempObj.GetComponent<TileAsset>().onTheCentre=true;
			tempObj.GetComponent<TileAsset>().onTheBoard=true;
		}
		if(_onTheBoard==true)
		{
			supplyATile();
		}
	}

}
