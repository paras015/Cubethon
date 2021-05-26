using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameEndStatus == false)
        {
            score.text = player.position.z.ToString("0");
        }
        
    }
}
