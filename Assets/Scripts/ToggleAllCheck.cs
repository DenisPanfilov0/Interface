using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace 
{
    public class ToggleAllCheck : MonoBehaviour
    {
        public List<Toggle> allToggles;
        
        private void Update()
        {
            allToggles = new List<Toggle>(FindObjectsOfType<Toggle>());
            GetComponent<Toggle>().onValueChanged.AddListener(ToggleAll);
        }

        void ToggleAll(bool isOn) 
        {
            foreach (Toggle toggle in allToggles) 
            {
                toggle.isOn = isOn;
            }
        }

    }
}