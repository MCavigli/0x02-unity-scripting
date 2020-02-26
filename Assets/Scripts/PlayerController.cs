using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody rb;
	public float speed = 500f;
	private int score = 0;

	void FixedUpdate()
	{
		if (Input.GetKey("w"))
		{
			rb.AddForce(0, 0, speed * Time.deltaTime);
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce((-1 * speed) * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey("s"))
		{
			rb.AddForce(0, 0, (-1 * speed) * Time.deltaTime);
		}
		if (Input.GetKey("d"))
		{
			rb.AddForce(speed * Time.deltaTime, 0, 0);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Pickup")
		{
			score += 1;
			Debug.Log("Score: " + score);
			Destroy(other.gameObject);
		}
	}
}
