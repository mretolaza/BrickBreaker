//María Mercedes Retolaza Reyma, 16339 
//Plataformas Moviles y Video Juegos, Sección: 10  
//Descripcion de la clase: Trabaja el movimiento de la raqueta en el juego  
using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    private Vector3 _posicion;
    private Ball _pelota;

    public bool autoPlay = false;
    // Use this for initialization
	void Start () {
        _posicion = new Vector3(0.5f, this.transform.position.y);
        _pelota = FindObjectOfType<Ball>();
    }
	
	// Update is called once per frame
	void Update () {
        MovePaddle();
	}

    void MovePaddle()
    {
        _posicion.x = autoPlay ? _pelota.transform.position.x : 
            Mathf.Clamp(16.0f * Input.mousePosition.x / Screen.width, 0.5f, 15.5f);

        transform.position = _posicion;
    }
}
