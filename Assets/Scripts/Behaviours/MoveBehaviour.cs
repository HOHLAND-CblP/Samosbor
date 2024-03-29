﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components;

public abstract class MoveBehaviour<T> : BaseBehaviour where T : IMovable
{
    protected T movable;
    protected MoveStates state;

    protected MoveBehaviour(T movable)
    {
        this.movable = movable;
    }
}