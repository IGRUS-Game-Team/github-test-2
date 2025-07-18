using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    Renderer renderers;

    private void Awake()
    {
        //scoreManager = GetComponent<ScoreManager>();
        
        renderers = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision other) 
    {//�÷��̾�� �΋H���� ���� = other

        Debug.Log("�΋H��");
        if (other.gameObject.tag == "Obstacle")
        {
            scoreManager.increaseScore(1);
            renderers.material.color = Color.cyan;
        }
    }
}
