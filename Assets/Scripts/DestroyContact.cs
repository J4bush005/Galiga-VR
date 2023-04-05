using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyContact : MonoBehaviour
{
    public float lives = 3f;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            lives--;
            Destroy(collision.gameObject);
            if(lives <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                score += 1000;
            }
            if(score > 1000)
            {
                SceneManager.LoadScene("Second Level");
            }
        }
    }
}
