using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private float AutoDestroyTime = 10f;
    [SerializeField]
    private bool SpawnInFixedUpdate = false;
    [SerializeField]
    private AutoDestroyText Prefab;

    private void Update()
    {
        if (!SpawnInFixedUpdate)
        {
            SpawnObject();
        }
    }

    private void FixedUpdate()
    {
        if (SpawnInFixedUpdate)
        {
            SpawnObject();
        }
    }
    private void SpawnObject()
    {
        AutoDestroyText text = Instantiate(
            Prefab,
           new Vector3(Random.Range(0,Screen.width),Random.Range(0,Screen.height),0),
           Quaternion.identity, //Quaternion-used for rotations, Quaternion.identity- to specify that there is no rotation
           transform
            );

        text.AutoDestroyTime = AutoDestroyTime;
    }
}
