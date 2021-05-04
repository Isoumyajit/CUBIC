
using UnityEngine;

public class groundtile : MonoBehaviour
{
    groundspawnner groundspwan;
    public GameObject obstaclesprefab;
    public GameObject doorPrefab;
    public GameObject _leftblankwallPrefab;
    public GameObject _piepPrefab;
    public GameObject _ringPrefab;
    public GameObject _powerPrefab;
    //public GameObject _ballPrefab;




    private void Start()
        {

        InvokeRepeating("spwanpowers", 5f, 1f);
        groundspwan = GameObject.FindObjectOfType<groundspawnner>();
        spwanObstacles();
            
        }

        private void OnTriggerExit(Collider other) {
            groundspwan.spwancube();
            Destroy(gameObject, 1); 
        }

        public void spwanObstacles(){

       
        int spwanIndex = Random.Range(3, 8);
        int[] pipespwanIndex = new int[] {8,9};

        

        Transform spwanpoint = transform.GetChild(pipespwanIndex[0]).transform;
        Instantiate(_piepPrefab, spwanpoint.position, Quaternion.identity, transform);
        spwanpoint = transform.GetChild(pipespwanIndex[1]).transform;


        

        Instantiate(_piepPrefab, spwanpoint.position, Quaternion.identity, transform);

        if(spwanIndex == 3)
        {
            Transform spwanPoint = transform.GetChild(spwanIndex).transform;
            Instantiate(_ringPrefab, spwanPoint.position, Quaternion.identity, transform);
        }
        else if (spwanIndex == 7)
        {
            Transform spwanPoint = transform.GetChild(spwanIndex).transform;
            Instantiate(_leftblankwallPrefab, spwanPoint.position, Quaternion.identity, transform);
            
        }
        else if(spwanIndex == 5)
        {
            Transform spwanPoint = transform.GetChild(spwanIndex + 1).transform;
            GameObject cube = Instantiate(obstaclesprefab, spwanPoint.position, Quaternion.identity, transform);

            spwanPoint = transform.GetChild(spwanIndex - 1 ).transform;
            Instantiate(obstaclesprefab, spwanPoint.position, Quaternion.identity, transform);

        }
        else
        {
            Transform spwanPoint = transform.GetChild(spwanIndex + 1).transform;
            GameObject cube = Instantiate(obstaclesprefab, spwanPoint.position, Quaternion.identity, transform);
        }
   
    }
    public void spwanpowers()
    {
        Debug.Log("yes powers got");
        Transform spwanPoint = transform.GetChild(2).transform;
        Instantiate(_powerPrefab, spwanPoint.position, Quaternion.identity, transform);
    }
    
}
