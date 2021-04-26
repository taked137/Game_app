using UnityEngine;
using System;
using System.Collections;

namespace festival.monster
{
    public class Kind : MonoBehaviour
    {
        public bool isGet { get; set; }
        public int rank { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string modelId { get; set; }
        public string text { get; set; }

        public Kind(string id, string name, string modelId, string text)
        {
            this.id = id;
            this.name = name;
            this.modelId = modelId;
            this.text = text;
        }
    }
}