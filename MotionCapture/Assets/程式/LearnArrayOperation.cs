using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnArrayOperation : MonoBehaviour {
    public int[] students = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
    // Use this for initialization
    void Start()
    {
        Debug.Log(students[6]);
        students[2] = 33;
        Debug.Log("學生陣列長度" + students.Length);
    }
}
