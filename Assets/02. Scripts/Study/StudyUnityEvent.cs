using UnityEngine;

public class StudyUnityEvent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake() {
        Debug.Log("Awake");
    }
    void Start()
    {
        Debug.Log("Start");
    }

    private void OnEnable() {
        Debug.Log("OnEnable");
    }

    void Update()
    {
        
    }
}
