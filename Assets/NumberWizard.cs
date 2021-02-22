using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		int max = 1000;
		int min = 0;

		Debug.Log("Benvenuto Viaggiatore! Io sono il mago dei numeri...");
		Debug.Log("Ora avvicinati a me e guardami dritto negli occhi mentre pensi ad un numero");
		Debug.Log("Ricorda però che i miei poteri sono limitati e non puoi dunque pensare ad un numero maggiore di " + max + "...");
		Debug.Log("o ad uno minore di " + min + "... Iniziamo!!!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
