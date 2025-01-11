using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> cubeList = new List<GameObject>();
    private GameObject lastCube;
    
    void Start()
    {
        UpdateLastCube();
    }

    
    void Update()
    {
        
    }

    public void IncreaseHero(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastCube.transform.position.x, lastCube.transform.position.y -2f, lastCube.transform.position.z);
        _gameObject.transform.parent = transform;
        cubeList.Add(_gameObject);
        UpdateLastCube();
    }

    public void DecreaseHero(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        cubeList.Remove(_gameObject);
        UpdateLastCube();
    }
    
    private void UpdateLastCube()
    {
        lastCube = cubeList[cubeList.Count - 1];
    }
}
