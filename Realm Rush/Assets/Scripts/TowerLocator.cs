using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLocator : MonoBehaviour
{
    
    [SerializeField] Transform weapon;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //Targets the enemy - Only object that contains the script is the enemy
        target = FindObjectOfType<EnemyMover>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        weapon.LookAt(target);
    }

}
