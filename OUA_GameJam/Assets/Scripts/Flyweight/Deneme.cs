using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    [SerializeField] Sira SiraDeneme;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material = SiraDeneme.material;
        GetComponent<MeshFilter>().mesh = SiraDeneme.mesh;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
