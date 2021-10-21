using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    public static int score;


    void Update()
    {

        scoreText.text = "Score: " + score;

    }
    

}