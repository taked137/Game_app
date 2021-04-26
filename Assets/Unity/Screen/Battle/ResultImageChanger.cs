using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultImageChanger : MonoBehaviour
{
    [SerializeField]
    private Sprite WinImage;

    [SerializeField]
    private Sprite LoseImage;

    public void AttachWinImage()
    {
        this.GetComponent<Image>().sprite = WinImage;
    }

    public void AttachLoseImage()
    {
        this.GetComponent<Image>().sprite = LoseImage;
    }
}
