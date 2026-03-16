using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float pipeMoveSpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeMoveSpeed * Time.deltaTime;
    }
}
