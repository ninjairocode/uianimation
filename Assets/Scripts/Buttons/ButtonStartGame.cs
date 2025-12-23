using UnityEngine;

namespace Buttons
{
    public class ButtonStartGame : MonoBehaviour
    {
        public ParticleSystem particles;
        
        public void OnClick()
        {
            particles.Play();
        }
    }
}
