using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public InputManager InputManager;
    public PlayerManager PlayerManager;

    void Start()
    {
        ManagerInit();
        ManagerReset();
    }

    void ManagerInit()
    {
        InputManager.ManagedInit();
        PlayerManager.ManagedInit();
    }

    void ManagerReset()
    {
        InputManager.ManagedReset();
        PlayerManager.ManagedReset();
    }

    void ManagerUpdate()
    {
        InputManager.ManagedUpdate();
        PlayerManager.ManagedUpdate();
    }
}
