using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CloseAndOpenMenu : MonoBehaviour
    {
        [SerializeField]private GameObject _menu;

        private void Start()
        {
            _menu = GameObject.FindWithTag("Menu");
        }

        public void OpenOrCloseMenu()
        {
            if (_menu.activeSelf == true)
            {
                _menu.SetActive(false);
            }
            else
            {
                _menu.SetActive(true);
            }
        }
        
    }
}