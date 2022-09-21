using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    int currentHitPoint = 0;
    // Start is called before the first frame update
    void Start()
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
            Destroy(gameObject);
        }
    }

}
