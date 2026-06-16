using UnityEngine;
using UnityEngine.SceneManagement;


public class Car: MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene("ClearScene");
	}
	[SerializeField] float speed = 40f;
	void Update()
	{
		transform.position += Vector3.left * speed * Time.deltaTime;

		if (transform.position.x < -750)
		{
			SceneManager.LoadScene("ClearScene");
		}
	}
}