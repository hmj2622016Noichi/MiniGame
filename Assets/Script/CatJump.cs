using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; //LoadScene‚ð‚Â‚©‚¤

public class CatJump : MonoBehaviour
{
	[SerializeField] float jumpForce = 0.01f;
	[SerializeField] Rigidbody2D rb;
	[SerializeField] ParticleSystem jumpEffect;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		GetComponent<ParticleSystem>().Play();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene("death");
	}

	void Update()
	{
		if (Keyboard.current.spaceKey.wasPressedThisFrame)
		{
			rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
			GetComponent<ParticleSystem>().Play();
		}

		if (transform.position.x < -12)
		{
			SceneManager.LoadScene("death");
		}

		if (transform.position.y < -4)
		{
			SceneManager.LoadScene("death");
		}

		if (transform.position.y > 4.7)
		{
			SceneManager.LoadScene("death");
		}
	}
}