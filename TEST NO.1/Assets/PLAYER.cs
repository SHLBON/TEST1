using UnityEngine;
using System.Collections;

public class PLAYER : MonoBehaviour {
	[Header("ده بتاع التحكم ")]
	public Rigidbody2D rb;

	[Header("ده بتاع الطلوع لفوق")]
	public int yspeed;
	public int xspeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
	void FixedUpdate(){
		rb.velocity =new Vector2(rb.velocity.x,yspeed);
		
		
		
		if (Input.GetAxisRaw("Horizontal")>0){
			rb.velocity =new Vector2(xspeed,rb.velocity.y);
		}else if (Input.GetAxisRaw("Horizontal")<0){
			rb.velocity =new Vector2(-xspeed,rb.velocity.y);
		}else{
			rb.velocity =new Vector2(0,rb.velocity.y);
		}

	}
}
