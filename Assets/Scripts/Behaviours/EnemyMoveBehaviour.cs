using Components;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

[RequireComponent(typeof(IMoveAndRotate))]
public class EnemyMoveBehaviour : MoveBehaviour<IMoveAndRotate>
{
    private IMoveAndRotate movable;

    private Vector3 targetPosition;
    private Vector3 startPosition;
    private float waitPeriod;
    private bool onTarget;

    public EnemyMoveBehaviour(IMoveAndRotate movable) : base(movable)
    {
    }

    private void Awake()
    {
        movable = GetComponent<IMoveAndRotate>();
    }

    private void Start()
    {
        startPosition = transform.position;
        targetPosition = transform.position + transform.forward * 5;
        Debug.Log(startPosition);
        
        onTarget = false;
    }

    private void Update()
    {
        Debug.Log(targetPosition);
        if (onTarget)
            Rotate();
        else
            Move();
        
    }


    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, movable.MoveSpeed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            onTarget = true;
            var temp = startPosition;
            startPosition = targetPosition;
            targetPosition = temp;
        }
    }


    private void Rotate()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(targetPosition - transform.position), movable.RotationSpeed * Time.deltaTime);
        if (transform.rotation == Quaternion.LookRotation(targetPosition - transform.position))
            onTarget = false;
    }

    public override void BehUpdate()
    {
        
    }

    public override void Pause()
    {
        
    }

    public override void UnPause()
    {
        
    }
}
