using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 20;
    [Tooltip("Adds amount to maxPoints when enemy dies")]
    [SerializeField] int difficultyRamp = 1;
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
            maxHitPoints += difficultyRamp;
            enemy.RewardGold();
        }
    }

}
