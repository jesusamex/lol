using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            SceneManager.LoadScene("Menu");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
