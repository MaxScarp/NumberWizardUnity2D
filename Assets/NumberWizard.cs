using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start ()
	{
		StartGame();
	}

	void StartGame()
    {
		max = 1000;
		min = 1;
		guess = 500;

		Debug.Log("Benvenuto Viaggiatore! Io sono il mago dei numeri...");
		Debug.Log("Ora avvicinati a me e guardami dritto negli occhi mentre pensi ad un numero");
		Debug.Log("Ricorda però che i miei poteri sono limitati e non puoi dunque pensare ad un numero maggiore di " + max + "...");
		Debug.Log("o ad uno minore di " + min + "... Iniziamo!!!");
		Debug.Log("Dimmi se il numero che hai pensato è minore o maggiore di " + guess);
		Debug.Log("Freccia su = Maggiore; Freccia giù = Minore; Enter = Corretto");

		max += 1; //Altrimenti non raggiungerò mai il numero 1000
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
			max = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.Return))
        {
			Debug.Log("Sono un mago, era ovvio che avrei indovinato...");
			StartGame();
		}
	}

	void NextGuess()
    {
		guess = (max + min) / 2;
		Debug.Log("Il numero è maggiore o minore di " + guess + "?");
	}
}
