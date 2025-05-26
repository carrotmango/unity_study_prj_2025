using UnityEngine;

public class StudySomething : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int currentLevel = 10;
    public int maxLevel = 99;

    void Start()
    {
        bool isMax = currentLevel >= maxLevel;

        Debug.Log($"현재 레벨은 만렙이 {(isMax ? "맞습니다" : "아닙니다.")}");

    }

    // Update is called once per frame

}
