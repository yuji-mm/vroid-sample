using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VroidLoader : MonoBehaviour
{

    [SerializeField] private CharacterModelHolder _modelHolder;

    public void LoadModel(int id)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        _modelHolder.SetModel(id, obj);
    }
}
