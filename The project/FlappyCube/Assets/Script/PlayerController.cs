using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
    public AudioClip swing;
    public AudioClip smash;

    public GUIText scoreLabel;


	void Start () {
		isStartButtonPressed = false;
		Time.timeScale = 0.0f;
       }
	
	// Update is called once per frame
	void Update() {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel(0);
        }
		updateScore();
		if(!isInView())
		{
			restartGame();
		}
		if(Input.anyKeyDown)
		{
			move();
            this.gameObject.AddComponent<AudioSource>();
            this.GetComponent<AudioSource>().clip = swing;
            this.GetComponent<AudioSource>().Play();
		}
	}
	
	private bool isInView()
	{
		Vector3 port = Camera.main.WorldToViewportPoint(transform.position);
		if((port.x < 1) && (port.x > 0) && (port.y < 1) && (port.y > 0) && port.z > 0)
		{
			return true;
		}
		else
		{
			return false;
		}
		
	}

	bool isStartButtonPressed;
    public 
	void OnGUI()
	{
		if (!isStartButtonPressed)
		{
			if(Input.anyKeyDown)
			{
				Time.timeScale = 1.0f;
				isStartButtonPressed = true;
			}
		}
	}

	private void move()
	{
		rigidbody.velocity = new Vector3(0,0,0);
		rigidbody.AddForce (new Vector3(275,200,0), ForceMode.Force);
	}

	void OnTriggerEnter(Collider other)
	{
		restartGame();
	}
	
	private void restartGame()
	{
		Time.timeScale = 0.0f;
		isStartButtonPressed = false;
		Application.LoadLevel (Application.loadedLevelName);	
	}

	private void updateScore()
	{
		int score = (int) (transform.position.x / GenerateWorld.distanceBetweenObjects);
		if(score != (int.Parse(scoreLabel.text)) && score > 0)
		{
			scoreLabel.text = score.ToString();
		}
		
	}
}
