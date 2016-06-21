using UnityEngine;
using System.Collections;

public class islandSpawn : MonoBehaviour {
    public GameObject islandPrefab;
    public float width;
    public float height;
    public float islandNumber;

	// Use this for initialization
	void Start () {
	    for(int i = 0; i < islandNumber; i++)
        {
            GameObject inst = Instantiate<GameObject>(islandPrefab);
            inst.transform.position = new Vector3(Random.Range(-width / 2, width / 2), 0, Random.Range(-height / 2, height / 2));
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
