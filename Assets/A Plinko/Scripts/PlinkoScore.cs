using UnityEngine;
using UnityEngine.UI;

public class PlinkoScore : MonoBehaviour
{
    public void Add(int points)
    {
        Text text = GetComponent<Text>();
        int score = int.Parse(text.text);
        score += points;
        text.text = score.ToString();
    }
}
