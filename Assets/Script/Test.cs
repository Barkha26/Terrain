using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject obj;
    public GameObject goTerrain;

    // tempo things
    Transform sphareTransform;

   void LateUpdate()
    {
        //Vector3 signPosition = new Vector3(transform.position.x, 0, transform.position.z);
        //signPosition.y = Terrain.activeTerrain.SampleHeight(signPosition) + Terrain.activeTerrain.GetPosition().y;
        //signPosition.y += 0.5f;
        //obj.transform.position = signPosition;


        //Vector3 pos = transform.position;
        //pos.y = Terrain.activeTerrain.SampleHeight(transform.position);
        ////transform.position = pos;
        //Debug.Log(Terrain.activeTerrain.SampleHeight(transform.position));
        //var Altitude = transform.position.y;
        //Debug.Log(Altitude);
        //Debug.Log(transform.position);


        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.DrawRay(ray.origin, ray.direction * 50000000, Color.red);
            // if (goTerrain.GetComponent<Collider>().Raycast(ray, out hit, Mathf.Infinity))

            if (Physics.Raycast(transform.position, transform.up,out hit))
            {
                Vector3 fwd = transform.TransformDirection(Vector3.up);
                sphareTransform = transform;
                Debug.DrawRay(transform.position, fwd * 50, Color.white);
                Debug.Log("hit");
                Debug.Log(hit.transform.position);

                //    transform.position = hit.point;
            }
            
        }

        if (sphareTransform != null)
        {
            Debug.DrawLine(transform.position, Vector3.down * 50, Color.white);
        }
    }
}
