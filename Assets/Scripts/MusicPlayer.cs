//María Mercedes Retolaza Reyma, 16339 
//Plataformas Moviles y Video Juegos, Sección: 10  
//Descripcion de la clase: Aquí se evalua la musica en el juego  
using UnityEngine;
using System.Collections;

public sealed class MusicPlayer : MonoBehaviour {

    private static MusicPlayer _instance;

    private MusicPlayer() { }
    
	void Awake () {
        if (_instance == null){
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }else {
            if (this != _instance)
                Destroy(this.gameObject);}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
