using UnityEngine;
using System.Collections;

public class SonicControllerScript : MonoBehaviour {

	public float maxSpeed = 10f;
	public float jForce = 700f;
	public Transform groundCheck;
	public LayerMask isGround;
	float groundRad = .2f;
	bool faceRight = true;
	bool onGround = false;

	Animator animate;

	void Start()
	{
		animate = GetComponent<Animator>();
	}
		
	void FixedUpdate () 
	{
		onGround = Physics2D.OverlapCircle (groundCheck.position, groundRad, isGround);
		animate.SetBool ("Ground", onGround);

		float moving = Input.GetAxis ("Horizontal");
		animate.SetFloat("Speed", Mathf.Abs(moving));

		animate.SetFloat ("vSpeed", GetComponent<Rigidbody2D> ().velocity.y);
		GetComponent<Rigidbody2D>().velocity = new Vector2 (moving * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (moving > 0 && !faceRight) 
		{
			Flip ();
		} else if (moving < 0 && faceRight) 
		{
			Flip ();
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.Space) && Input.anyKeyDown))
		{
			animate.SetBool ("Ground", false);
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jForce));
		} 

		else
		{
			animate.SetBool ("Ground", true);
		}

		if (Input.GetKeyDown (KeyCode.LeftShift) || Input.GetKeyDown (KeyCode.RightShift)) 
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2 (100f, 0));
		}
	}

	void Flip()
	{
		faceRight = !faceRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
