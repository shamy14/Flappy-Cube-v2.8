using UnityEngine;
using System.Collections;

public class controlPipe : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector2 SS = renderer.material.mainTextureScale;
        SS.x = transform.localScale.x;
        SS.y = transform.localScale.y;
        renderer.material.mainTextureScale = SS;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
