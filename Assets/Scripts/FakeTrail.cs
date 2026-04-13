using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class FakeTrail : MonoBehaviour
{
    public float lifetime = 3f;
    public float minDistance = 0.1f;
    public Vector3 worldVelocity = Vector3.left * 3f;

    private LineRenderer line;
    private List<Vector3> points = new List<Vector3>();
    private List<float> times = new List<float>();

    void Awake()
    {
        line = GetComponent<LineRenderer>();
        line.useWorldSpace = true;
        AnimationCurve curve = new AnimationCurve();
        curve.AddKey(0f, 0.4f); 
        curve.AddKey(1f, 0f);   

        line.widthCurve = curve;
    }

    void Update()
    {
        
        if (points.Count == 0 || Vector3.Distance(transform.position, points[0]) > minDistance)
        {
            points.Insert(0, transform.position);
            times.Insert(0, Time.time);
        }

        Vector3 move = worldVelocity * Time.deltaTime;

        for (int i = 0; i < points.Count; i++)
        {
            points[i] += move;
        }

        for (int i = points.Count - 1; i >= 0; i--)
        {
            if (Time.time - times[i] > lifetime)
            {
                points.RemoveAt(i);
                times.RemoveAt(i);
            }
        }

        line.positionCount = points.Count;
        line.SetPositions(points.ToArray());
    }
}