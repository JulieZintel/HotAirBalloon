using UnityEngine;
using System.Collections;

public class Ballon : MonoBehaviour {
	public float HorizontalSpeed;
	public float FlapSpeed;
	private Rigidbody2D myRigidbody;
	private static float score;
	public float alphalevel = 0.1f;
	public Sprite myTexture;
	SpriteRenderer sprite;
	public Sprite otherTexture1;
	public Texture2D otherTexture2;
	public Texture2D otherTexture3;
	public Sprite otherTexture5;



	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 velocity = myRigidbody.velocity;
		//FOR BALLON MOVING
		if (Input.GetKeyDown (KeyCode.W)) {
			velocity.y = FlapSpeed;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			velocity.y = FlapSpeed *-1;
		}
		if (Input.GetKeyDown (KeyCode.A)){
			velocity.x = HorizontalSpeed *-1;
		}
		if(Input.GetKeyDown(KeyCode.D)){
			velocity.x = HorizontalSpeed *1;
		}

		/*
		//FOR WORLD MOVING
		if (Input.GetKeyDown (KeyCode.S)) {
			velocity.y = FlapSpeed;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			velocity.y = FlapSpeed *-1;
		}

		if (Input.GetKeyDown (KeyCode.D)){
			velocity.x = HorizontalSpeed *-1;
		}
		if(Input.GetKeyDown(KeyCode.A)){
			velocity.x = HorizontalSpeed *1;
		}*/
		///////////////////////////////////////////// 
/// 
/// 
		myRigidbody.velocity = velocity;
		if (Input.GetMouseButton (0)) {
			Debug.Log ("Pressed left click.");
			Application.LoadLevel ("final"); 
		}
	}

	 void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.name == "Film"){
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.
			GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ballon1-2");
			GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Balloon2");

		} else if (other.gameObject.name == "Laur") {
			GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Balloon1-3");
			Destroy (other.gameObject); // Des			troys the icon.
			Destroy (GameObject.FindWithTag("sky"));
			score += 1; // 1 point is added to the player's score.
			GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Balloon3");

		} else if (other.gameObject.name == "Samtid") {
			GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Balloon1-4");
			Destroy (other.gameObject); // Destroys the icon.
			Destroy (GameObject.FindWithTag("Balloon3"));
			score += 1; // 1 point is added to the player's score.
			GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Balloon4");

		} else if (other.gameObject.name == "Fav") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.
		}
		else if (other.gameObject.name == "Love") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.
		}
		else if (other.gameObject.name == "Vampire") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.

		}
		else if (other.gameObject.name == "Rom") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.

		}
		else if (other.gameObject.name == "Dys") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.

		}
		else if (other.gameObject.name == "Even") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.

		}
		else if (other.gameObject.name == "Magt") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.

		}
		else if (other.gameObject.name == "Hot") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.

		}
		else if (other.gameObject.name == "Smuk") {
			Destroy (other.gameObject); // Destroys the icon.
			score += 1; // 1 point is added to the player's score.

		}
	}

// Function which displays a GUI with the user's score.
/*void OnGUI(){
	GUI.Box(new Rect(10,10,100,20), "Score:" + score); // Displays the score in the corner, while the game is still going.
	//	if (this.gameObject.name == "Film") {
		//	GUI.DrawTexture (new Rect (127, 115, 127, 280), myTexture);
		} */
	}
