using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesGenarate : MonoBehaviour
{
	public float maxoffset;
	public GameObject blockPrefab;
	public Transform start;
	public static int n;
	private GameObject block;
	private int offset;

    private void Start()
    {
		block = Instantiate(blockPrefab, start.position, Quaternion.identity) as GameObject;
		n = 1;
		offset = 0;
    }

    private void Update()
    {
        while(n < 50)
        {
            int random = Random.Range(0, 2);

            if(offset == maxoffset)
            {
                random = 0;
            }
            else if(offset == -maxoffset)
            {
                random = 1;
            }

            Vector3 newpos = block.transform.position;

            if(random == 1)
            {
                newpos.x++;
                offset++;
            }
            else
            {
                newpos = block.transform.position;
                newpos.z++;
                offset--;
            }

            block = Instantiate(blockPrefab, newpos, Quaternion.identity) as GameObject;
            n++;
        }
    }
}
