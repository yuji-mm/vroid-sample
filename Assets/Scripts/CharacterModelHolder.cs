using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModelHolder : MonoBehaviour
{
    private GameObject[] _models = new GameObject[3];

    [SerializeField] private CharacterSelectButtonController _characterSelectButtonController;

    public void DontDestroyModels()
    {
        transform.parent = null;
        DontDestroyOnLoad(gameObject);
    }

    public void SetModel(int id, GameObject obj)
    {
        obj.transform.parent = transform.GetChild(id);
        Vector3 buttonPos = _characterSelectButtonController.GetButtonPos(id);
        buttonPos.z = -Camera.main.transform.position.z;
        obj.transform.position = Camera.main.ScreenToWorldPoint(buttonPos);
        _models[id] = obj;
    }
}
