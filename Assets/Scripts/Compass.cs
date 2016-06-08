using UnityEngine;
using System.Collections;

public class Compass : MonoBehaviour {
	public Transform target1;
	public Transform target2;
	public Transform target3;
	public float speed = 10f;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {


//		void TargetCollision (){
//			if (target1){

		Vector3 vectorToTarget = target1.position - transform.position;

		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime / speed);

//			}
//			else if (target2){
		Vector3 vectorToTarget2 = target2.position - transform.position;		

		float angler = Mathf.Atan2(vectorToTarget2.y, vectorToTarget2.x) * Mathf.Rad2Deg;
		Quaternion r = Quaternion.AngleAxis(angler, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, r, Time.deltaTime / speed);

//			}
//			else if(target3){
		Vector3 vectorToTarget3 = target3.position - transform.position;	

		float angles = Mathf.Atan2(vectorToTarget3.y, vectorToTarget3.x) * Mathf.Rad2Deg;
		Quaternion s = Quaternion.AngleAxis(angles, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, s, Time.deltaTime / speed);
//			}

	/*		this.transform.LookAt (target1, Vector2.up);
			this.transform.LookAt (target2, Vector2.up);
			this.transform.LookAt (target3, Vector2.up);*/
		}
	}
//}
	
