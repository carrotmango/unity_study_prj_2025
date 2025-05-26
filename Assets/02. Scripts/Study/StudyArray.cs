using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour {
    int[] arrayNumber = new int[5] {1,2,3,4,5};
    List<int> listNumber = new List<int>();

    int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;

    [SerializeField]
    private int number4 = 4;

    [SerializeField]
    private int number5 = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Array0: {arrayNumber[0]}");
        Debug.Log($"Array4: {arrayNumber[4]}");

        listNumber.Add(10);
        listNumber.Add(20);
        listNumber.Add(30);
        listNumber.Add(40);
    }
}
