using UnityEngine;
using UnityEngine.UI;
using MobfishCardboard;

namespace MobfishCardboardDemo
{
    public class RecenterScript : MonoBehaviour
    {
        public Button recenterButton;

        // Start is called before the first frame update
        private void Start()
        {
            if (recenterButton != null)
                recenterButton.onClick.AddListener(RecenterCamera);

        }

        // Update is called once per frame
        private void RecenterCamera()
        {
            CardboardManager.RecenterCamera();
        }
    }
}