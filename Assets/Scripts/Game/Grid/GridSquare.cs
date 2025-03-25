using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSquare : MonoBehaviour
{
    public Image normalImage;
    public Image hooverImage;
    public Image activeImage;
    public List<Sprite> normalImages;

    public bool Selected { get; set; }
    public int SquareIndex { get; set; }
    public bool SquareOccupied { get; set; }


    private void Start()
    {
        Selected = false;
        SquareOccupied = false;
    }
    // temp funcition. Remove it.
    public bool CanWeUseThisSquare()
    {
        return hooverImage.gameObject.activeSelf;
    }
    public void PlaceShapeOnBoard()
    {
        ActiveSquare();

    }
    public void ActiveSquare()
    {
        hooverImage.gameObject.SetActive(false);
        activeImage.gameObject.SetActive(true);
        Selected = true;
        SquareOccupied = true;
    }
    public void SetImage(bool setFristImage)
    {
        normalImage.GetComponent<Image>().sprite = setFristImage ? normalImages[1] : normalImages[0];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SquareOccupied == false)
        {
            Selected = true;
            hooverImage.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Selected = true;
        if (SquareOccupied == false)
        {

            hooverImage.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (SquareOccupied == false)
        {
            Selected = false;
            hooverImage.gameObject.SetActive(false);
        }
    }

}
