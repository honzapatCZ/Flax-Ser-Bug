using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game
{
    public class Parent : Script
    {
        [Serialize]
        Actor theActor;
        [NoSerialize]
        public Actor TheActor
        {
            get => theActor;
            set => theActor = value;
        }
    }
}
