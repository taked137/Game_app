using UnityEngine;
using System.Collections;
using packt.UI;
using packt.Managers;
using System;

namespace packt.Controllers
{
    public class SettingSceneController : MonoBehaviour
    {
        public void OnCloseSetting()
        {
            GameManager.Instance.CloseSetting(this);
        }
    }
}
