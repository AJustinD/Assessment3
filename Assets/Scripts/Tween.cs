using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    public Transform Target { get; set; }
    public Vector3 StartPos { get; set; }
    public Vector3 EndPos { get; set; }
    public float StartTime { get; set; }
    public float Duration { get; set; }

    public Tween(Transform T, Vector3 SP, Vector3 EP, float ST, float D)
    {
        this.Target = T;
        this.StartPos = SP;
        this.EndPos = EP;
        this.StartTime = ST;
        this.Duration = D;
    }
}
