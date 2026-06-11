using UnityEngine;
using UnityEngine.SceneManagement;


public class CarMove : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene("ClearScene");
	}
	[SerializeField] float speed = 40f;
	void Update()
	{
		transform.position += Vector3.left * speed * Time.deltaTime;

		if (transform.position.x < -700)
		{
			SceneManager.LoadScene("ClearScene");
		}
	}
}