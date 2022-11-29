using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    [Serializable]// need to show in inspector
    public class CapsuleColliderUtility 
    {
        public CapsuleColliderData CapsuleColliderData {get; private set;}
        [field: SerializeField] public DefaultColliderData DefaultColliderData {get; private set;}
        [field: SerializeField] public SlopeData SlopeData {get; private set;}

        public void Initialize(GameObject gameObject)
        {
            if(CapsuleColliderData != null)
            {
                return;
            }

            CapsuleColliderData = new CapsuleColliderData();

            CapsuleColliderData.Initialize(gameObject);//CapsuleColliderData.Initialize(gameObject, CapsuleColliderData.Collider.center);
        }

        public void CalculateCapsuleColliderDimensions()
        {
            SetCapsuleColliderRadius(DefaultColliderData.Radius);

            SetCapsuleColliderHeight(DefaultColliderData.Height * (1f - SlopeData.StepHeightPercentage)); //multiply by - stepheight % i.e. 25%

            RecalculateCapsuleColliderCenter();

            float halfColliderHeight = CapsuleColliderData.Collider.height / 2f;

            if (halfColliderHeight < CapsuleColliderData.Collider.radius)// if height is double or less than radius so the collider will just turn small, no negative centering shiz
            {
                SetCapsuleColliderRadius(halfColliderHeight);
            }

            CapsuleColliderData.UpdateColliderData();
        }

        //method for radius
        public void SetCapsuleColliderRadius(float radius)
        {
            CapsuleColliderData.Collider.radius = radius;
        }

        //method for height
        public void SetCapsuleColliderHeight(float height)
        {
            CapsuleColliderData.Collider.height = height;
        }

        public void RecalculateCapsuleColliderCenter()
        {
            float colliderHeightDifference = DefaultColliderData.Height - CapsuleColliderData.Collider.height;

            Vector3 newColliderCenter = new Vector3(0f, DefaultColliderData.CenterY + (colliderHeightDifference/2f), 0f);

            CapsuleColliderData.Collider.center = newColliderCenter;
        }
    }
}
