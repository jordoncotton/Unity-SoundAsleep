using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowUpBehaviour : MonoBehaviour
{

    public bool Glow;

    public Material glowMat;

    public float Emissy;

    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        Emissy = 1;
        glowMat.EnableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
        glowMat.SetColor("_EmissionColor", new Color(34, 34, 34) * Emissy);
    }
}
