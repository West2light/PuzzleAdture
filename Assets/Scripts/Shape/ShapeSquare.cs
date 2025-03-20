using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class ShapeSquare : MonoBehaviour
{
    public Image occupiedImage;

    private void Start()
    {
        occupiedImage.gameObject.SetActive(true);
    }

}