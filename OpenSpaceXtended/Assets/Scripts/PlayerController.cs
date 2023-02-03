using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask Ground;
    public GameObject Body;
    public GameObject Head;

    private RaycastHit hit;


    void Update()
    {
        CheckGroundHeight();
    }


    private void CheckGroundHeight()
    {
        if (Physics.Raycast(Head.transform.position, Vector3.down, out hit, Mathf.Infinity, Ground))
        {
            Body.transform.localScale = new Vector3(0.2f, Vector3.Distance(Head.transform.position, hit.point) / 2 - 0.1f, 0.2f);
            Body.transform.position = new Vector3(Head.transform.position.x, hit.point.y + Vector3.Distance(Head.transform.position, hit.point) / 2 - 0.1f, Head.transform.position.z - 0.1f);
        }
        else
        {
            transform.Translate(9.81f * Time.deltaTime * Vector3.down);
        }

    }

}
