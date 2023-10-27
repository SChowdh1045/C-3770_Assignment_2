using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool dead = false;

    private void Update()
    {
        if(transform.position.y < -3)
        {
            Die();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !dead)
        {
            GetComponent<MeshRenderer>().enabled = false; // makes the player invisible
            GetComponent<MovePlayer>().enabled = false; // stops user input from being read
            GetComponent<Rigidbody>().isKinematic = false; // stops physics from other objects being applied to player
            Die();
        }
    }

    void Die()
    {
        Invoke(nameof(reloadLevel), 1.3f); // reload the game after 1.3 seconds
        dead = true;
    }

    private void reloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
