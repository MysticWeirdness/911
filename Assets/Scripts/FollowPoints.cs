using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPoints : MonoBehaviour
{
    private float speed = 0.025f;
    private int currentPoint = 1;
    private GameManager gameManager;
    [SerializeField] private List<Transform> points = new List<Transform>();

    private void Awake()
    {
        foreach(Transform point in GameObject.FindWithTag("PathsObject").GetComponentsInChildren<Transform>())
        {
            points.Add(point);
        }
        points.RemoveAt(0);
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>(); 
    }
    private void Start()
    {
        transform.position = points[0].position;
    }

    private void Update()
    {
        if(transform.position == points[currentPoint].position)
        {
            if (currentPoint >= points.Count - 1)
            {
                gameManager.EnemyReachedTheEnd();
                Destroy(gameObject);
            }
            else
            {
                currentPoint++;
            }
        }
        MoveTowardsNewPoint();
    }

    private void MoveTowardsNewPoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[currentPoint].position, speed);
    }
}
