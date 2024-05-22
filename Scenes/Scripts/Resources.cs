using UnityEngine;

namespace Scenes.Scripts
{
    public class Resources : MonoBehaviour
    {
        public ShopManager ShopManager => shopManager;

        public BackpackManager BackpackManager => _backpackManager;

        public PanelMovement PanelMovement => _panelMovement;

        [SerializeField] private ShopManager shopManager;
        [SerializeField] private BackpackManager _backpackManager;
        [SerializeField] private PanelMovement _panelMovement;
    }
}