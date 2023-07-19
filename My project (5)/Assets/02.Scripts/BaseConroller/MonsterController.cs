using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float Timer = 2.0f;

    public void Update()
    {
        Timer -= Time.deltaTime;

        if(Timer <= 0)
        {
            Timer = 2.0f;
            //Manager.Object.Despawn(this);
        }
    }
}
