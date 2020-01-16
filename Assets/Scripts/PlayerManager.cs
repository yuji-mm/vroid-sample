using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Manager
{
    Transform _characterParent;
    GameObject[] _models = new GameObject[3];
    GameObject _playerModel;

    override public void ManagedInit()
    {
        _characterParent = GameObject.Find("CharacterModelHolder").transform;
        for (int i = 0; i < _characterParent.childCount; i++)
        {
            _models[i] = _characterParent.GetChild(i).gameObject;
        }
        SetPlayerModel(0);
    }

    override public void ManagedReset()
    {

    }

    override public void ManagedUpdate()
    {

    }

    void SetPlayerModel(int id)
    {
        for (int i = 0; i < _models.Length; i++)
        {
            GameObject model = _models[i];
            if (i == id)
            {
                _playerModel = model;
                model.transform.parent = transform;
                model.transform.GetChild(0).position = transform.position;
                model.SetActive(true);
            }
            else
            {
                model.SetActive(false);
                model.transform.parent = _characterParent;
            }
        }
    }
}
