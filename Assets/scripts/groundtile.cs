
using UnityEngine;

public class groundtile : MonoBehaviour
{
        groundspawnner groundspwan;
        public GameObject ObstaclePrefab;

        private void Start()
        {
            groundspwan = GameObject.FindObjectOfType<groundspawnner>();
            spwanObstacle();
        }

        private void OnTriggerExit(Collider other) {
            
            groundspwan.spwancube();
            Destroy(gameObject, 2); 
        }

        void spwanObstacle(){
            
            //choose random points to spwan obstacles
             int getspwanIndex = Random.Range(2, 5);
            Transform spwanIndex = transform.GetChild(getspwanIndex).transform;
            //spwan the obstacle at that particular position

            Instantiate(ObstaclePrefab, spwanIndex.position, Quaternion.identity, transform);
        }
}
