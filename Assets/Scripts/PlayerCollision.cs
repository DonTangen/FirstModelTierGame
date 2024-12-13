using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public int score = 0;
    public Text GameOver;
void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            GameOver.enabled = true;
            FindAnyObjectByType<GameManager>().EndGame();
        }
        else if(collisionInfo.collider.tag == "Chicken")
        {
            score++;
        }
    }
}
