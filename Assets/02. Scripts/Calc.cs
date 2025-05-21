using UnityEngine;

public class Calc : MonoBehaviour {
    public int number1, number2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        int result1 = AddMethod();

        int result2 = MinusMethod();

        Debug.Log($"µ¡¼À: {result1} / »¬¼À: {result2}");

    }
    int AddMethod() {
        int result = number1 + number2;
        return result;
    }

    int MinusMethod() {
        int result = number1 - number2;
        return result;
    }
}
