using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public enum TileTypes
{
	diamond,heart,Arrow,direction,bonus,insurance
}
[ExecuteInEditMode]
public class TileAsset : MonoBehaviour {

[Header("Tile Info")]
//public int IndexNO;
public string tileName;
public TileTypes TileTypes;
public int tileNumber;

[Header("Tile state")]
public bool onTheBoard=false;
public bool onTheCentre=false;


[Header("Tile Images")]
public RectTransform TileFront;

public RectTransform TileBack;

	void Start (){
		tileName=gameObject.name;


		
//rote();
	}
	// Update is called once per frame
	void Update () {

		if(gameObject.transform.localEulerAngles.y<90f){
		TileBack.gameObject.SetActive(false);
		TileFront.gameObject.SetActive(true);
		//Debug.Log("face");
		}
		if(gameObject.transform.localEulerAngles.y>=90f)
		{
		TileBack.gameObject.SetActive(true);
		TileFront.gameObject.SetActive(false);
		//Debug.Log("back");
		//Debug.Log(tileName);
		}
		


		
	}


	
}
