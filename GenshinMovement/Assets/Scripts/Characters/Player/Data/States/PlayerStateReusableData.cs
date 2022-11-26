using UnityEngine;

namespace GenshinMovement
{
    public class PlayerStateReusableData
    {
       public Vector2 MovementInput { get; set; }
       public float MovementSpeedModifier { get; set; } = 1f;

       public bool ShouldWalk { get; set; }

       private Vector3 currentTargetRotation;
       private Vector3 timeToReachTargetRotation;
       private Vector3 dampedTargetRotationCurrentVelocity;
       private Vector3 dampedTargetRotationPassedTime;

       public ref Vector3 CurrentTargetRotation
       {
            get
            {
                return ref currentTargetRotation;//cause our property is method
            }
       }

       public ref Vector3 TimeToReachTargetRotation
       {
            get
            {
                return ref timeToReachTargetRotation;//cause our property is method
            }
       }
       public ref Vector3 DampedTargetRotationCurrentVelocity
       {
            get
            {
                return ref dampedTargetRotationCurrentVelocity;//cause our property is method
            }
       }
       public ref Vector3 DampedTargetRotationPassedTime
       {
            get
            {
                return ref dampedTargetRotationPassedTime;//cause our property is method
            }
       }
    }
}
