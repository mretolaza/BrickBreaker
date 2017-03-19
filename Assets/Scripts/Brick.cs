//María Mercedes Retolaza Reyma, 16339 
//Plataformas Moviles y Video Juegos, Sección: 10  
//Descripcion de la clase: Aqui se miran los golpes que se le dan a los bloques. 
using UnityEngine;
using System.Collections;
using System;

public class Brick : MonoBehaviour {

    private LevelManager _levelManager;
    private int _maxHits;
    private int _hits;
    private bool _isBreakable;

    public static int breakCount = 0;
    public delegate void BrickDestroyed();
    public static event BrickDestroyed OnBrickDestroyed;
    public AudioClip crack;

    public Sprite[] _hitSprites;
	// Use this for initialization
	void Start () {
        _hits = 0;
        _maxHits = _hitSprites.Length + 1;
        _levelManager = FindObjectOfType<LevelManager>();
        _isBreakable = this.tag != "Unbreakable";

        if (_isBreakable){
            breakCount++;} 
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (_isBreakable) {
            HandleDamage();
        }
    }

    private void HandleDamage()
    {
        _hits++;
        if (_hits >= _maxHits) {
            DestroyBrick();
        }else{
            LoadSprites();
        }
    }

    void PlayDestroy()
    {
        AudioSource.PlayClipAtPoint(crack, transform.position, volume: .05f);
    }

    void DestroyBrick()
    {
        PlayDestroy();
        Destroy(gameObject);
        breakCount--;
        if (OnBrickDestroyed != null) {
            OnBrickDestroyed();
        }
    }

    private void LoadSprites()
    {
        int spriteIndex = Mathf.Min(_hits - 1, _hitSprites.Length - 1);
        if (_hitSprites[spriteIndex] != null){
            GetComponent<SpriteRenderer>().sprite = _hitSprites[spriteIndex];
        }
    }
}
