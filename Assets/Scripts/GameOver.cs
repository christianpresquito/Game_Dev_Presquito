using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour
{
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            

           
            Time.timeScale = 0f;

           
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            
            Invoke("RestartGame", 2f);
        }
    }

    
    void RestartGame()
    {
        
        Time.timeScale = 1f;

      
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

      
    }
}