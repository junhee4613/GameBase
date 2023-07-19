using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;
    static Managers Instance { get { Init(); return s_instance; } }

    public static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);  //Scene �� ����ǵ� �ı����� �ʰ�
            s_instance = go.GetComponent<Managers>();
        }


    }
    PoolManager _pool = new PoolManager();

    public static PoolManager Pool { get { return Instance?._pool; } }
    public static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { name = "@Manager" };
            }
        }
    }

    PoolManager _pool = new PoolManager();
    ResourceManager _ressource = new ResourceManager();
    ObjectManager 
}