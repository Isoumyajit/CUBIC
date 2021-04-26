
using UnityEngine;

public class groundtile : MonoBehaviour
{
        groundspawnner groundspwan;

        private void Start()
        {
            groundspwan = GameObject.FindObjectOfType<groundspawnner>();
        }

        private void OnTriggerExit(Collider other) {
            groundspwan.spwancube();
            Destroy(gameObject, 2); 
        }
}
