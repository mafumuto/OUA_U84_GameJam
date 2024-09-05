using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trajectory : MonoBehaviour
{
    private Scene _scene;
    private PhysicsScene physicsScene;
    // Start is called before the first frame update
    void Start()
    {
        _scene = SceneManager.GetActiveScene();
        physicsScene = _scene.GetPhysicsScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
