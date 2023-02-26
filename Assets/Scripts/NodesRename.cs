using System.Collections.Generic;
using UnityEngine;

public class NodesRename : MonoBehaviour
{
    [SerializeField] private List<GameObject> _collection;
    [SerializeField] private string _newName;

    private void Start()
    {
        foreach (var element in _collection)
            element.name = _newName;
    }
}
