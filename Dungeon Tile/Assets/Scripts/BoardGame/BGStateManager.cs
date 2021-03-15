using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGStateManager : MonoBehaviour
{
    public BGM bgm;

    public enum BGStates { IsFlipping, Static, Moving }
    public BGStates bgState = BGStates.Static;

    private void OnEnable()
    {
        bgState = BGStates.Static;
    }
}
