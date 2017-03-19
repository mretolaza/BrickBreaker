//María Mercedes Retolaza Reyma, 16339 
//Plataformas Moviles y Video Juegos, Sección: 10  
//Descripcion de la clase: Evalua las colisiones  
using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    private LevelManager _levelmanager;
	// Use this for initialization
	void Start () {
        _levelmanager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {}

    void OnTriggerEnter2D(Collider2D collider) {
        _levelmanager.LoadLevel("Win"); }
    
    void OnCollisionEnter2D(Collision2D collision)
    { }
}
