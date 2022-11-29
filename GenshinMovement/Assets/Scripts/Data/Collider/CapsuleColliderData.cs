using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    public class CapsuleColliderData 
    {
        public CapsuleCollider Collider { get; private set;}
        public Vector3 ColliderCenterInLocalSpace { get; private set;}

        public void UpdateColliderData()
        {
            ColliderCenterInLocalSpace = Collider.center;
        }

        public void Initialize(GameObject gameObject)// so script is reusable
        {
            if(Collider != null)
            {
                return;
            }

            Collider = gameObject.GetComponent<CapsuleCollider>();

            UpdateColliderData();
        }
    }
}
