using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    public Sprite myPlayer;
    public Rigidbody2D image;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        SpriteRenderer sRend = image.GetComponent<SpriteRenderer>();
        sRend.sprite = myPlayer;
    }
}
