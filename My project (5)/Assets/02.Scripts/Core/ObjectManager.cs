using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using UnityEngine;
using static Define;

public class ObjectManager
{
    public HashSet<MonsterController> Monsters { get; } = new HashSet<MonsterController>();

    public Transform MonsterTransform
    {
        get
        {
            GameObject root = GameObject.Find("@Monster");
            if (root == null)
                root = new GameObject { name = "@Monster" };

            return root.transform;
        }
    }

    public ObjectManager()
    {
        Init();
    }
    public void Init()
    {

    }
    public void Clear()
    {
        Monsters.Clear();
    }

    public T Spawn<T>(Vector3 position) where T : BaseController    //where T의 자료형은 상속받은 클래스이거나 그 클래스의 파생 클래스여야한다.
    {
        System.Type type = typeof(T);

        if(type == typeof(MonsterController))
        {
            GameObject go = Managers.Resource.Instantiate("Monster", pooling: true);
            MonsterController mc = go.GetOrAddComponent<MonsterController>();
            go.transform.position = position;
            Monsters.Add(mc);
            return mc as T;
        }

        return null;
    }

    public void Despawn<T>(T obj) where T : BaseController
    {
        System.Type type = typeof(T);

        if(type == typeof(MonsterController))
        {
            Monsters.Remove(obj as MonsterController);
            Managers.Resource.Destroy(obj.gameObject);
        }
    }
}
