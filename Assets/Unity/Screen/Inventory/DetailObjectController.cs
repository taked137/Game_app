using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace packt.UI
{
    public class DetailObjectController : MonoBehaviour
    {
        public GameObject monsterdetail;
        public GameObject exitbutton;

        public MonsterDetail mod;
        public void OnDetailObject()
        {
            print("object active");
            monsterdetail.SetActive(true);
        }

        public void OffDetailObject()
        {
            monsterdetail.SetActive(false);
            exitbutton.SetActive(true);
        }

        public void OffExitButton()
        {
            exitbutton.SetActive(false);
        }

        public void MDchangetext(string text)
        {
            mod = monsterdetail.GetComponent<MonsterDetail>();
            mod.changetext(text);
        }

        public void MDchangepicture(Texture texture)
        {
            mod = monsterdetail.GetComponent<MonsterDetail>();
            mod.changepicture(texture);
        }

    }
}
