
using UnityEngine;

public class groundtile : MonoBehaviour
{
        groundspawnner groundspwan;
        public GameObject obstaclesprefab;
        public GameObject doorPrefab;
        public GameObject _leftblankwallPrefab;
        public GameObject _piepPrefab;

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
        int[] pipespwanIndex = new int[] {6,7};
        Transform spwanpoint = transform.GetChild(pipespwanIndex[0]).transform;
        Instantiate(_piepPrefab, spwanpoint.position, Quaternion.identity, transform);
        spwanpoint = transform.GetChild(pipespwanIndex[1]).transform;
        Instantiate(_piepPrefab, spwanpoint.position, Quaternion.identity, transform);

        if (spwanIndex == 6)
        {
            Transform spwanPoint = transform.GetChild(spwanIndex).transform;
            Instantiate(doorPrefab, spwanPoint.position, Quaternion.identity, transform);
        }
        else if (spwanIndex == 5)
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
