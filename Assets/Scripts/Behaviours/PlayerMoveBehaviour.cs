using Components;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoveBehaviour : MoveBehaviour<IMoveAndRotate>
{
    //cache
    private Camera mainCam;

    public PlayerMoveBehaviour(IMoveAndRotate movable) : base(movable)
    {
    }

    private void Awake()
    {
        if (!TryGetComponent<IMoveAndRotate>(out movable))
            Debug.Log("Пиздос, добавь move component");

        mainCam = Camera.main;
    }

    public void Update()
    {
        Move();
        Rotate();
    }

    

    private void Move()
    {
        Vector3 direction =
            new Vector3(InputController.Instance.VerticalMove + InputController.Instance.HorizontalMove,
                        0,
                        -InputController.Instance.HorizontalMove + InputController.Instance.VerticalMove);

        if (direction.magnitude > 1)
            direction = direction.normalized;

        transform.position += 
            new Vector3(movable.MoveSpeed * direction.x * Time.deltaTime,
                        0,
                        movable.MoveSpeed * direction.z * Time.deltaTime);
    }

    private void Rotate()
    {
        var groundPlane = new Plane(Vector3.up, transform.position);
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

        if (groundPlane.Raycast(ray, out float dist))
        {
            Vector3 point = ray.GetPoint(dist);
            transform.LookAt(point);
        }
    }

    public override void Pause()
    {
        throw new NotImplementedException();
    }

    public override void UnPause()
    {
        throw new NotImplementedException();
    }

    public override void BehUpdate()
    {
        throw new NotImplementedException();
    }
}
