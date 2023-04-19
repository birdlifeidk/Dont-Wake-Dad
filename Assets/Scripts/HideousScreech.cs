using UnityEngine;

namespace DefaultNamespace
{
    public class HideousScreech : MonoBehaviour
    {
        public GameObject stairTrigger;
        public AudioSource hideousSqueak;

        public void Start()
        {
            Invoke("DelaySound", 0.1f);
        }

        public void DelaySound()
        {
            hideousSqueak.enabled = true;
        }


        public void OnCollisionEnter(Collision collision)
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                hideousSqueak.Play();
                GameManager.Instance.soundCount++;
            }
        }
    }
}