
using UnityEngine;

public class groundtile : MonoBehaviour
{
        groundspawnner groundspwan;
        public GameObject obstaclesprefab;
        public GameObject doorPrefab;
        public GameObject _leftblankwallPrefab; 

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

            int spwanIndex = Random.Range(2, 6);
        if (spwanIndex == 6)
        {
            Transform spwanPoint = transform.GetChild(spwanIndex).transform;
            Instantiate(doorPrefab, spwanPoint.position, Quaternion.identity, transform);
        }
        if(spwanIndex == 5)
        {
            Transform spwanPoint = transform.GetChild(spwanIndex).transform;
            Instantiate(_leftblankwallPrefab, spwanPoint.position, Quaternion.identity, transform);
        }
        else
        {
            Transform spwanPoint = transform.GetChild(spwanIndex).transform;
            Instantiate(obstaclesprefab, spwanPoint.position, Quaternion.identity, transform);
        }

        }
}
