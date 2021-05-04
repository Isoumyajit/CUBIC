
using UnityEngine;

public class groundspawnner : MonoBehaviour
{
    public GameObject groundplane;
    Vector3 nextspwanpoint;

    public void spwancube(){
        GameObject temp = Instantiate(groundplane, nextspwanpoint, Quaternion.identity);
        nextspwanpoint = temp.transform.GetChild(1).transform.position;
    }

    private void Start(){

        for (int i = 1 ; i <= 10 ; i++){
            spwancube();
        }
     
    }
}
