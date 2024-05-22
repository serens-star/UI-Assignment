using System.Collections.Generic;
using UnityEngine;

namespace Scenes.Scripts
{
    public class BackpackManager : MonoBehaviour
    {
          public List<MovableInventoryItem> upgrades = new List<MovableInventoryItem>();

          public int maxPossibleItems = 10;
          
          public void AddToBackPack(MovableInventoryItem item)
          {
              if (upgrades.Count >= maxPossibleItems)
              {
                  upgrades.Add(item);
              }
              
              // Render on the UI
          }

          public void Sell(MovableInventoryItem item)
          {
              var index = upgrades.FindIndex(x => x == item);
              upgrades.RemoveAt(index);
              
              //SceneController.Instance.SceneResources.ShopManager.SellToShop(item);
              
          }
    }
}