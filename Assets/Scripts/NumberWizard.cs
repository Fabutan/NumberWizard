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
	public int maxGuessesAllowed = 15;

	void Start() {
		minimum = 1;
		maximum = 1000;
		guess = Random.Range (minimum,maximum+1);
		guessTextField.text = guess.ToString();
		maximum = maximum + 1;
		triesRemaining.text = maxGuessesAllowed + " Attempts Remain";
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
		guess = Random.Range (minimum, maximum+1);

		guessTextField.text = guess.ToString();
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene ("Win");
		}
	}



}
