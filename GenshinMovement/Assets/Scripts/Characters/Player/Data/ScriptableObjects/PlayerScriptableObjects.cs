using UnityEngine;

namespace GenshinMovement
{
    [CreateAssetMenu(fileName = "Player", menuName = "Custom/Characters/Player")]//way to create scriptable objects
    public class PlayerScriptableObjects : ScriptableObject
    {
        [field: SerializeField] public PlayerGroundedData GroundedData { get; private set;}//serialized so it can be set in inspector
    }
}
