using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    public interface InterfaceState 
    {   
        public void Enter();
        //run when state becomes the current state
        public void Exit();
        //run when state becomes the previous state
        public void HandleInput();
        //run logic when reading input
        public void Update();
        //non physics update
        public void PhysicsUpdate();
        //physics update


    }

}
