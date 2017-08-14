using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileTypeIs{
	diamond,heart,Arrow,direction,bonus,insurance
}
[ExecuteInEditMode]
public class CubeTileAsset : MonoBehaviour {

[Header("=Tile Info=")]
public TileTypeIs TileTypeIs;
public int tileNumber;

public Sprite frontImage;

[Header("=Tile state=")]
public bool onTheBoard=false;
public bool onTheCentre=false;
public bool onTheWall=false;
public bool withThePlayer=false;


	// Use this for initialization
	void Start () {
	GameObject tempObj=gameObject.transform.Find("CubeCanvas").gameObject;
	GameObject tempObj2=tempObj.transform.Find("Front").gameObject;
	frontImage=tempObj2.GetComponent<SpriteRenderer>().sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
