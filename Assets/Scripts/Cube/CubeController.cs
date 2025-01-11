using UnityEditor.Callbacks;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] public HeroStackController heroStackController;
    private bool isStack = false;
    private RaycastHit hit;
    private Vector3 direction =  Vector3.back;
    
    void Start()
    {
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();
    }


    void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {
        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                heroStackController.IncreaseHero(gameObject);
                SetDirection();

            }

            if (hit.transform.name == "Obstacle")
            {
                heroStackController.DecreaseHero(gameObject);
            }
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
