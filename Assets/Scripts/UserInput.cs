using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UserInput : MonoBehaviour
{
    [Header("Output Signals")]
    public float Horizontal;
    public float Vertical;

    public float Magnitude;
    public Vector3 Direction;

    /// <summary>
    /// pressing signal
    /// </summary>
    public bool Run;
    /// <summary>
    /// trigger once signal
    /// </summary>
    
    /// <summary>
    /// double trigger signal
    /// </summary>
    [Header("Others")]
    public bool InputEnabled = true;

    /// <summary>
    /// Elliptical Grid Mapping
    /// 椭圆映射法
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    protected Vector2 SquareToCircle(Vector2 input)
    {
        Vector2 output = Vector2.zero;
        output.x = input.x * Mathf.Sqrt(1 - (input.y * input.y) / 2.0f);
        output.y = input.y * Mathf.Sqrt(1 - (input.x * input.x) / 2.0f);
        return output;
    }
}
