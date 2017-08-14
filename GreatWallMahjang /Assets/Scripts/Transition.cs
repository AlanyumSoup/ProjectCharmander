using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toStartScene(){
		SceneManager.LoadScene("StartScene");
	}
	public void toRuleScene(){
		SceneManager.LoadScene ("RuleTopScene");
	}

	public void toTutorialScene(){
		SceneManager.LoadScene ("TutorialScene");
	}

	public void toInformationScene(){
		SceneManager.LoadScene("InformationScene");
	}

	public void toLink(){
		Application.OpenURL("https://www.amazon.com/GREAT-WALL-international-mahjong-culture/dp/146368830X");
	}

	public void backToTheTutorialTop(){
		SceneManager.LoadScene("TutorialScene");
	}
	public void toFirstTutorialScene(){
		SceneManager.LoadScene ("FirstTutorialScene");
	}

	public void toSecondTutorialScene(){
		SceneManager.LoadScene("SecondTutorialScene");
	}

	public void toThirdTutorialScene(){
		SceneManager.LoadScene("FourthTutorialScene");
	}

	public void toSetupTutorialScene(){
		SceneManager.LoadScene("SetupTutorialScene");
	}

public void toDifferentTilesScene(){
		SceneManager.LoadScene("DifferentTilesScene");
	}

	public void toHandsTopScene(){
		SceneManager.LoadScene("HandsTopScene");
	}

public void toGroupTilesScene(){
		SceneManager.LoadScene("GroupTypeScene");
	}

public void toThirdBasicRuleScene(){
		SceneManager.LoadScene("ThirdBasicRuleScene");
	}

public void toChickenScene(){
		SceneManager.LoadScene("ChickenScene");
	}

	public void toOneGroupScene(){
		SceneManager.LoadScene("OneGroupScene");
	}

	public void toFlushScene(){
		SceneManager.LoadScene("FlushScene");
	}

	public void toCORNERSScene(){
		SceneManager.LoadScene("CORNERSScene");
	}

	public void toISLANDScene(){
		SceneManager.LoadScene("ISLANDScene");
	}

	public void toACTIVE_DRAGON(){
		SceneManager.LoadScene("ACTION_DRAGONScene");
	}
}
