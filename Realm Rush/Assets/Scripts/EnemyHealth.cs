using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 20;
    int currentHitPoint = 0;

    Enemy enemy;

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void onEnable()
    {
        currentHitPoint = maxHitPoints;
    }

    private void OnParticleCollision(GameObject other) {
        ProccessHit();
    }

    void ProccessHit()
    {
        currentHitPoint--;
        if(currentHitPoint <= 0)
        {
            gameObject.SetActive(false);
            enemy.RewardGold();
        }
    }

}
