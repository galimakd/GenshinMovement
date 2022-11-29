using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    [Serializable]
    public class DefaultColliderData 
    {
        [field: SerializeField] public float Height {get; private set;} = 1.8f;
        [field: SerializeField] public float CenterY {get; private set;} = 0.9f;//half of height
        [field: SerializeField] public float Radius {get; private set;} = 0.2f;
    }
}
