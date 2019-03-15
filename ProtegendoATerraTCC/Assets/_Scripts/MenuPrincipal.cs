﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour {

	public void IniciarJogo(){
		SceneManager.LoadScene (3);
	}
	public void SairJogo(){
		Debug.Log ("Sair");
		Application.Quit ();
	}
	public void Creditos(){
		SceneManager.LoadScene (4);
	}
	public void RetornaMenuPrincipal(){
		SceneManager.LoadScene (0);
	}
    public void Prologo()
    {
        SceneManager.LoadScene(2);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(1);
    }
}