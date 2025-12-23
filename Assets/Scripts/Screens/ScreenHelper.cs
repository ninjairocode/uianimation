using UnityEngine;

namespace Screens
{
    public class ScreenHelper : MonoBehaviour
    {
        public ScreenType screenType;

        public void OnClick()
        {
            Debug.Log("Clique detectado");
            Debug.Log("Instance: " + ScreenManager.Instance);

            ScreenManager.Instance.ShowByType(screenType);
        }
        
    }
}
