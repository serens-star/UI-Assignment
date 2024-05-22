using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMovement : MonoBehaviour
{
    private RectTransform rectTransform;
    public float xChestPosition = 2501.197f;
    public float yChestPosition = -449.0045f;
    public float xShopPosition = 471.9594f;
    public float yShopPosition = -449.0045f;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void MoveToChest()
    {
        rectTransform.anchoredPosition = new Vector2(xChestPosition, yChestPosition);
    }

    public void MoveToShop()
    {
        rectTransform.anchoredPosition = new Vector2(xShopPosition, yShopPosition);
    }
}
