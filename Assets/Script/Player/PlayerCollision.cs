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
    {//플레이어와 부딫히는 모든것 = other

        Debug.Log("부딫힘");
        if (other.gameObject.tag == "Obstacle")
        {
            scoreManager.increaseScore(1);
            renderers.material.color = Color.cyan;
        }
    }
}
