using UnityEngine;

public class FinishTriggerPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player has entered the trigger
        if (collision.CompareTag("Player"))
        {
            // Call the LevelManager to load the next level
            LevelManager.instance.NextLevel();
        }
    }
}
