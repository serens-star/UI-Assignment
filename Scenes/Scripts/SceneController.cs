using System;
using UnityEngine;

namespace Scenes.Scripts
{
    public class SceneController : MonoBehaviour
    {
        private static SceneController instance;

        public static SceneController Instance => instance;

        [SerializeField] private Resources sceneResources;

        public Resources SceneResources => sceneResources;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}