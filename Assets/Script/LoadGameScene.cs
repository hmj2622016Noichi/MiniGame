using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
	float span = 4.0f;
	float delta = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene("GameScene");
	}

	// Update is called once per frame
	void Update()
    {
		delta += Time.deltaTime;
		if (this.delta > this.span)
		{
			SceneManager.LoadScene("GameScene");
		}
    }
}
