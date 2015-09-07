using UnityEngine;
using System.Collections;

public class audiomaneger : MonoBehaviour {

       private static audiomaneger instance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

 
 public static audiomaneger GetInstance (){
     return instance;
 }
  
 void  Awake (){

     if (instance != null && instance != this) {
         Destroy(this.gameObject);
         return;
     } else {
         instance = this;
     }
     DontDestroyOnLoad(this.gameObject);
 }
}
