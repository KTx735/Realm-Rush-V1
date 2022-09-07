using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    float secondToWait = 2f;
    [SerializeField] List<Waypoint> path = new List<Waypoint>();

    void Start()
    {
        Debug.Log("Start Here");
        StartCoroutine(FollowPath());
        Debug.Log("Finish Start");
    }

    IEnumerator FollowPath()
    {
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(secondToWait);
        }
    }
}
