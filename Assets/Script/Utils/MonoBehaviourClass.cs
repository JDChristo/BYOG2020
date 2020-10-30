using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourClass : MonoBehaviour
{
    [SerializeField] protected GameObject view;
    [SerializeField] protected GameObject controller;
    protected T SetController<T>() where T : MonoBehaviour
    {
        return controller.GetComponentInChildren<T>();
    }
    protected T SetView<T>() where T : MonoBehaviour
    {
        return view.GetComponentInChildren<T>();
    }
}
