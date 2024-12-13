using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public PlayerCollision player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.score.ToString();
    }
}
