using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] bool isPlaceable;
    
    //Property isPlaceable
    public bool IsPlaceable
    {
        get{ return isPlaceable; }
    }

    void OnMouseUpAsButton() 
    {
        if(isPlaceable)
        {
            bool isPlaced =  towerPrefab.CreateTower(towerPrefab, transform.position); //This acts similar to Instantiate
            isPlaceable = !isPlaced;
        }
    }
}
