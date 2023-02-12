using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Vector2 targetPosition;
    public float stepMove = 2;

    public void Start()
    {
        targetPosition = GetRandomPoint();
    }

    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, stepMove*Time.deltaTime);

        if ((Vector2)transform.position == targetPosition)
        {
            targetPosition = GetRandomPoint();
        }
    }

    public Vector2 GetRandomPoint()
    {
        Vector2 randomVector = new Vector2(0, 0);
        randomVector.x = Random.Range(-6, 6);
        randomVector.y = Random.Range(-4, 4);

        return randomVector;
    }
}
