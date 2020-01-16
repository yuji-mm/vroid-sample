using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectButtonController : MonoBehaviour
{
    private Transform[] _children;
    [SerializeField] private VroidLoader _loader;

    void Start()
    {
        _children = new Transform[transform.childCount];
        for (int i = 0; i < _children.Length; i++)
        {
            _children[i] = transform.GetChild(i);
        }
    }

    public void OnPressed(int id)
    {
        Vector3 buttonPos = Camera.main.ScreenToViewportPoint(_children[id].position);
        _loader.LoadModel(id);
        HideButton(_children[id]);
    }

    public void HideButton(Transform button)
    {
        Image image = button.GetComponent<Image>();
        Color c = image.color;
        c.a = 0;
        image.color = c;
    }

    public Vector3 GetButtonPos(int id)
    {
        return _children[id].position;
    }
}
