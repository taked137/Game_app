using UnityEngine;
using System;
using System.Collections;

namespace festival.monster
{
    public class Monster : MonoBehaviour
    {
        public string id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public Kind kind { get; set; }

        public Monster(string id, string latitude, string longitude, Kind kind)
        {
            this.id = id;
            this.latitude = latitude;
            this.longitude = longitude;
            this.kind = kind;
        }
    }
}