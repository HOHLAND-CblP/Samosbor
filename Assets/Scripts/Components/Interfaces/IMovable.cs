using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Components
{
    public interface IMovable : IHaveMoveSpeed
    {
        
    }

    public interface IMoveAndRotate : IMovable, IHaveRotationSpeed, IHaveStoppingDistance
    {

    }

    public enum MoveStates
    { 
        DEFAULT = 0,
        MOVE = 1,
        WAIT = 2,
        PAUSE = 3
    }

    public interface IHaveStoppingDistance
    {
        float StoppingDistance { get; }
    }
    public interface IHaveRotationSpeed
    { 
        float RotationSpeed { get; }
    }
    public interface IHaveMoveSpeed
    {
        float MoveSpeed { get; }
    }
}