using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json;

namespace HeavenStudio
{
    public class EntityTypes
    {
        public struct Integer
        {
            public int min;
            public int val;
            public int max;

            public Integer(int min, int max, int val = 0)
            {
                this.min = min;
                this.val = val;
                this.max = max;
            }
        }

        public struct Float
        {
            public float min;
            public float val;
            public float max;

            public Float(float min, float max, float val = 0f)
            {
                this.min = min;
                this.val = val;
                this.max = max;
            }
        }
    }
}