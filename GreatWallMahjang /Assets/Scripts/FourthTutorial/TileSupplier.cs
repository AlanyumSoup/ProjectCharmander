using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileSupplier : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Invoke("supplyATile",4.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void supplyATile(){
		int random = Random.Range(1,145);
		Debug.Log(random+" Test");
		GameObject tempObj= GameObject.Find(random.ToString());
		bool _onTheBoard= tempObj.GetComponent<CubeTileAsset>().onTheBoard;
		if(_onTheBoard==false)
		{
			
			iTween.MoveTo(tempObj,iTween.Hash("position",new Vector3(0,0,0),"time",0.2f));
			iTween.RotateTo(tempObj,iTween.Hash("x",-15f,"time",0.1f));
			tempObj.GetComponent<CubeTileAsset>().onTheCentre=true;
			tempObj.GetComponent<CubeTileAsset>().onTheBoard=true;
		}
		if(_onTheBoard==true)
		{
			supplyATile();
		}
	}
}
