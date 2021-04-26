
using UnityEngine;

public class groundtile : MonoBehaviour
{
        groundspawnner groundspwan;
        public GameObject obstaclesprefab;

        private void Start()
        {
            groundspwan = GameObject.FindObjectOfType<groundspawnner>();
            spwanObstacles();
        }

        private void OnTriggerExit(Collider other) {
            groundspwan.spwancube();
            Destroy(gameObject, 1); 
        }

        public void spwanObstacles(){

            int spwanIndex = Random.Range(2, 5);
            Transform spwanPoint = transform.GetChild(spwanIndex).transform;
            Instantiate(obstaclesprefab, spwanPoint.position, Quaternion.identity, transform);
        }
}
