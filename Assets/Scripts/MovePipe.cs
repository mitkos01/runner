using UnityEngine;


public class MovePipe : MonoBehaviour
{
    public float pipeMoveSpeed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pipeMoveSpeed += Time.deltaTime;

        transform.position += Vector3.left * pipeMoveSpeed * Time.deltaTime;
    }
}
