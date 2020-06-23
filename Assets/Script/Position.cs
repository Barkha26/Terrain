using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{

    public GameObject terrainPos;
    public GameObject ballPos;

    // Start is called before the first frame update
    void Start()
    {
      //  Debug.Log(terrainPos.transform.position);
      //  Debug.Log(ballPos.transform.position);
      //  Debug.Log(terrainPos.transform.position - ballPos.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 50000000, Color.red);

            if (terrainPos.GetComponent<Collider>().Raycast(ray, out hit, Mathf.Infinity))
            { 
               Vector3 pos = hit.point - terrainPos.transform.position;
                //Instantiate(ballPos, terrainPos.transform, true);
                //ballPos.transform.position = pos;
                GameObject obj = Instantiate(ballPos, hit.point, Quaternion.identity);
                obj.transform.SetParent(terrainPos.transform);
                Debug.Log(pos);
            }
           
        }
    }
}
