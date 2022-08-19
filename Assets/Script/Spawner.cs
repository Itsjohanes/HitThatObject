using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    //public GameObject[] targets2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());

       
        
    }
        IEnumerator SpawnTarget(){
            while(true){
                yield return new WaitForSeconds(spawnRate);
                int index = Random.Range(0,targets.Count);
                Instantiate(targets[index]);
            }
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
