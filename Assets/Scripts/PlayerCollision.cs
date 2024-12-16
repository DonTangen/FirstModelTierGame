using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public int score = 0;
    public Text GameOver;
    public Vector3 chickenDeath;
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
