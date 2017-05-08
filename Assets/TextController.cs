using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {


	public Text text;

	private enum GameStates {text1, text2};
	private GameStates gameState;

	// Use this for initialization
	void Start () {
		gameState = GameStates.text1;
		text.text = "HELLOOOOOOO!";
	}
		
	#region update state
	// Update is called once per frame
	void Update () {
		change_on_space();
	}

	void change_on_space() {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (gameState == GameStates.text1) {
				// change to text2 
				gameState = GameStates.text2;
				text.text = "Hiiiiiiiiiii!!";

			} else if (gameState == GameStates.text2) {
				// change to text1
				gameState = GameStates.text1;
				text.text = "HELLOOOOOOO!";
			}
		}
	}

	#endregion
}
