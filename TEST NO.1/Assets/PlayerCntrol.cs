using UnityEngine;
using System.Collections;

public class PlayerCntrol : MonoBehaviour {
	private Rigidbody2D Rb;

	[Header("السرعه والتحكم")]
	public int Xspeed;
	public float Yspeed;
	// Use this for initialization
	void Start () {
		Rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate	 (){
		//A للاتجاه للاعلى بسرعه سابته 
		Rb.velocity =new Vector2 (Rb.velocity.x,Yspeed);

		//a الاتجاه يمين و يسار
		if (Input.GetAxisRaw("Horizontal")<0){
			Rb.velocity =new Vector2 (-Xspeed,Rb.velocity.y);
		}
		else if (Input.GetAxisRaw("Horizontal")>0){
			Rb.velocity = new Vector2 (Xspeed,Rb.velocity.y);
		}else{
			Rb.velocity = new Vector2 (0,Rb.velocity.y);
		}
		//------------------

	}
}
