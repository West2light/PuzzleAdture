using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSquare : MonoBehaviour
{
    public Image normalImage;
    public List<Sprite> normalImages;

    void Start()
    {

    }

    void Update()
    {

    }
    public void SetImage(bool setFristImage)
    {
        normalImage.GetComponent<Image>().sprite = setFristImage ? normalImages[1] : normalImages[0];
    }
}
