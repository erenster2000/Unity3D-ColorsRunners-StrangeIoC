using System;
using Runtime.Data.ValueObject;
using strange.extensions.signal.impl;
using StylizedWater2;
using UnityEngine;

namespace Runtime.Signals
{
    public class PlayerSignals
    {
        public Signal<Transform, PlayerForceData> onForceCommand = new Signal<Transform, PlayerForceData>();
        public Signal<byte> onStageAreaSuccessful = new Signal<byte>();
        public Signal<Material> OnColorChangerTriggered = new Signal<Material>();
        public Signal<GameObject> StackAddObj = new Signal<GameObject>();
        

    }
}