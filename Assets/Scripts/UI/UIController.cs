using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class UIController : MonoBehaviour
    {
        private HashSet<IUIHandler> _handlers;

        public static UIController Instance;

        public void Awake()
        {
            _handlers = new HashSet<IUIHandler>();
            if (Instance == null)
                Instance = this;
        }

        public GameObject HookWindow(IUIHandler handler)
        {
            GameObject ob = Resources.Load<GameObject>(handler.GetPrefabPath());
            GameObject gameObject = Instantiate(ob, this.gameObject.transform);
            gameObject.transform.SetParent(this.gameObject.transform);
            gameObject.SetActive(true);
            _handlers.Add(gameObject.GetComponent<IUIHandler>());
            return gameObject;
        }

        public void RemoveWindow(IUIHandler handler)
        {
            IUIHandler window;
            _handlers.TryGetValue(handler, out window);

            if (window != null)
                Destroy(window.ThisGameObject);
        }
    }
}
