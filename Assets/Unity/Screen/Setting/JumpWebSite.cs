using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpWebSite : MonoBehaviour
{


    public void JumpTerms()
    {
        Application.OpenURL("https://c0de-web.club.nitech.ac.jp/apps/meikoudaigoing/term/");
    }

    public void JumpLicense()
    {
        Application.OpenURL("https://c0de-web.club.nitech.ac.jp/apps/meikoudaigoing/license");
    }

    public void JumpPolicy()
    {
        Application.OpenURL("https://c0de-web.club.nitech.ac.jp/apps/meikoudaigoing");
    }
}
