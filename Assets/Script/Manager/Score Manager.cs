using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    int score = 0;

    public void increaseScore(int amount) //
    {
        Debug.Log("���ھ� ����");

        //���ھ� ���� ����
        score += amount;

        //tmp �ؽ�Ʈ
        scoreText.text = $"Score: {score}";

    }
}
