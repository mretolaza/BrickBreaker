//María Mercedes Retolaza Reyma, 16339 
//Plataformas Moviles y Video Juegos, Sección: 10  
//Descripcion de la clase: En esta clase, se habilita la opcion del "click en el mouse" para identificar 
//cuando se tienen los movimientos y las colisiones en los bloques 

using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Paddle _raqueta;
    private bool _reboteEnPelota;
    private Vector3 _raquetaPelota;
	// Use this for initialization
	void Start () {
        _raqueta = FindObjectOfType<Paddle>();
        _raquetaPelota = this.transform.position - _raqueta.transform.position;
        _reboteEnPelota = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!_reboteEnPelota){
            this.transform.position = _raqueta.transform.position + _raquetaPelota;

            if (Input.GetMouseButtonDown(0)){
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                _reboteEnPelota = true;
            }
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f));
        this.GetComponent<Rigidbody2D>().velocity += velocityTweak;

        if(_reboteEnPelota)
            GetComponent<AudioSource>().Play();
    }
}
