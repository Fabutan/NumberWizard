using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {

	public Text guessTextField;
	public Text triesRemaining;

	int maximum;
	int minimum;
	int guess;
	int maxGuessesAllowed = 10;

	void Start() {
		maximum = 1000;
		minimum = 1;
		guess = 500;

		maximum = maximum + 1;
		triesRemaining.text = maxGuessesAllowed + " Attempts Remain";
	}

	void GameStart () {
	
	}

	public void GuessHigher () {
		minimum = guess;
		NextGuess();
		print ("Guess Higher " + guess);
	}

	public void GuessLower () {
		maximum = guess;
		NextGuess();
		print ("Guess Lower " + guess);
	}
		
	void NextGuess () {
		maxGuessesAllowed = maxGuessesAllowed - 1;
		triesRemaining.text = maxGuessesAllowed + " Attempts Remain";

		//guess = (minimum + maximum) / 2;

		guess = Random.Range (minimum, maximum);

		guessTextField.text = "Is your number " + guess + "?";
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene ("Win");
		}
	}



}
