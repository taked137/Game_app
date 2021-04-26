using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterDetail : MonoBehaviour
{
    [Header("Original")]
    protected Text Text;
    protected RawImage Image;

    public void start()
    {
        Text = transform.Find("Text").gameObject.GetComponent<Text>();
        Image = transform.Find("RawImage").gameObject.GetComponent<RawImage>();    
    }
    public void changetext(string t)
    {
        start();
        print("changetext");
        Text.text=t;
        print("テキストを変更");
    }
    
    public void changepicture(Texture tex)
    {
        start();
        print("changepiture");
        Image.texture = tex;
        print("画像を変更");
    }
}
