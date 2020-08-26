using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Win")
        {
            SceneManager.LoadScene("Win");
        }
    }
}
