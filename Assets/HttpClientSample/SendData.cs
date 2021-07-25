using System;
using UnityEngine;

namespace HttpClientSample
{
    [Serializable]
    public struct SendData
    {
        public string name;
        public Vector3 position;
        public Quaternion rotation;
    }
}