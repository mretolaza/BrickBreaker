//María Mercedes Retolaza Reyma, 16339 
//Plataformas Moviles y Video Juegos, Sección: 10  
//Descripcion de la clase: Aqui se intercambian las escenas para identificar los niveles en los que va el jugador 
using UnityEngine;
using System.Collections;
using System;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LlamadoAEventos();
	}

    private void LlamadoAEventos() {
        Brick.OnBrickDestroyed += PartidaGanada;
    }

    private void PartidaGanada() {
        if(Brick.breakCount <= 0){
            LoadNextLevel();
        }
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void LoadLevel(string name) {
        Application.LoadLevel(name);
        Brick.breakCount = 0;
    }

    public void LoadNextLevel() {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public void Quit(){
        Application.Quit();
    }
}
