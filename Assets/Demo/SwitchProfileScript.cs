using UnityEngine;
using UnityEngine.UI;
using MobfishCardboard;

namespace MobfishCardboardDemo
{
    public class SwitchProfileScript : MonoBehaviour
    {
        public Button switchButton;
        public string targetUrl;

        // Start is called before the first frame update
        private void Start()
        {
            if (switchButton != null)
                switchButton.onClick.AddListener(SwitchProfile);
        }

        private void SwitchProfile()
        {
            CardboardManager.SetCardboardProfile(targetUrl);
        }
    }
}