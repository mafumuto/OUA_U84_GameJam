using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme2 : MonoBehaviour
{
    [SerializeField] Sira2 Sira2;
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<MeshRenderer>().material = Sira2.mt;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        
    }
}