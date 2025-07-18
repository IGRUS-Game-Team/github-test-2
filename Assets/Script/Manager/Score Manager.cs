using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    int score = 0;

    public void increaseScore(int amount) //
    {
        Debug.Log("스코어 증가");

        //스코어 누적 증가
        score += amount;

        //tmp 텍스트
        scoreText.text = $"Score: {score}";

    }
}
