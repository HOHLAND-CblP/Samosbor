using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Components
{
    public class MovableComponent : MonoBehaviour, IMoveAndRotate
    {
        [SerializeField] private float moveSpeed = 3;
        [SerializeField] private float rotationSpeed = 3;
        [SerializeField] private float stoppingDistance = 0.1f;

        public float MoveSpeed => moveSpeed;
        public float RotationSpeed => rotationSpeed;
        public float StoppingDistance => stoppingDistance;
    }
}