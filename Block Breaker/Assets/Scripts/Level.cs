using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // parameters
    [SerializeField] int blocks;  //Serialized for debugging purposes

    // cached reference
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        blocks++;
    }

    public void BlockDestroyed()
    {
        blocks--;
        if(blocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
