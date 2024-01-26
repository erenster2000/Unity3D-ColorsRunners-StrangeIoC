using System;
using Runtime.Data.ValueObject;
using strange.extensions.signal.impl;
using StylizedWater2;
using UnityEngine;

namespace Runtime.Signals
{
    public class StackSignals
    {
        public Signal DefineStack = new Signal();
        public Signal Interacted = new Signal();
        public Signal<GameObject, int> onCollectableStack = new Signal<GameObject, int>();
        public Signal<GameObject, int> ExtractFromStack = new Signal<GameObject,int>();
        public Signal<Vector2> onStackPlayerFollow = new Signal<Vector2>();
        public Signal<Vector2> onStackMover = new Signal<Vector2>();
        
    }
}