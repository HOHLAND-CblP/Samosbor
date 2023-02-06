using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBehaviour : MonoBehaviour, IBehaviour
{
    public abstract void BehUpdate();

    public abstract void Pause();

    public abstract void UnPause();
}
