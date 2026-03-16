using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1.5f;
    public float heightRange = 0.45f;
    public GameObject pipePrefab;

    public float timer;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(pipePrefab, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
