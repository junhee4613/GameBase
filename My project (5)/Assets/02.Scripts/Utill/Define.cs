using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utill;

public class Define
{
    public enum Scene
    {
        Unknown,
        TitleScene,
        LobbyScene,
        GameScene
    }

    public enum Sound
    {
        Bgm,
        SubBgm,
        Effect,
        Max
    }

    public enum UIEvent
    {
        Click,
        Pressed,
        PointerDown,
        PointerUp,
        BeginDrag,
        Drag,
        EndDrag,
    }

    public enum ObjectType
    {
        Player,
        Monster,
    }
    

}
