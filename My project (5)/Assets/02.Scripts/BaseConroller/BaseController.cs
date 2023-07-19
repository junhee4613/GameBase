using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    public ObjectType objectType { get; protected set; }

    bool _init = false;

    private void Awake()
    {
        
    }
    public virtual bool Init()
    {
        if (_init)
            return false;

        _init = true;
        return true;
    }
}
