using System;
using UnityEngine;

namespace GenshinMovement
{
    [Serializable]
    public class PlayerRotationData
    {
       [field: SerializeField] public Vector3 TargetRotationReachTime {get; private set;}
    }
}
