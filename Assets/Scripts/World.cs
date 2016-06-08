using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

	public Texture2D myTexture;

	void Start () {
		myTexture = Resources.Load("StorytelBalloon") as Texture2D;
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI ()
	{
//		GUI.Box(new Rect(10,10,100,20), "Score:" + score); // Displays the score in the corner, while the game is still going.

		if (this.gameObject.name == "Film") {
			GUI.DrawTexture (new Rect (0, 0, 10, 20), myTexture);
		}

	}
}