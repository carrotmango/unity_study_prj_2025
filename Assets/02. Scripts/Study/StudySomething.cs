using UnityEngine;

public class StudySomething : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int currentLevel = 10;
    public int maxLevel = 99;

    void Start()
    {
        bool isMax = currentLevel >= maxLevel;

        Debug.Log($"���� ������ ������ {(isMax ? "�½��ϴ�" : "�ƴմϴ�.")}");

    }

    // Update is called once per frame

}
