using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fluorescein : MonoBehaviour
{
    private Renderer rend;
    float fluorange;
    float start;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        fluorange = rend.sharedMaterial.GetFloat("_Hue");
        start = fluorange;
    }

    // Update is called once per frame
    void Update()
    {
        fluorange += Time.deltaTime / 2;

        if (fluorange == 1)
        {
            fluorange = 0;
        }

        rend.sharedMaterial.SetFloat("_Hue", fluorange);
    }

    private void OnDisable()
    {
        rend.sharedMaterial.SetFloat("_Hue", start);
    }
}
