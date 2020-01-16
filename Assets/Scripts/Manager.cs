using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Manager : MonoBehaviour
{
    abstract public void ManagedInit();
    abstract public void ManagedReset();
    abstract public void ManagedUpdate();
}
