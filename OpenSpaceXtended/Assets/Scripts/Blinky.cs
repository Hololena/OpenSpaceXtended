using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinky : MonoBehaviour
{
    private MeshRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        StartCoroutine("Blink");
    }


    private IEnumerator Blink()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            renderer.enabled = !renderer.enabled;
        }
    }


}
