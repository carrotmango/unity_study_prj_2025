using UnityEngine;

public class Study_ClassStruct : MonoBehaviour
{
    public class StudyClass {
        public int number;

        public StudyClass(int number) {
            this.number = number;
        }
    }

    public struct StudyStruct {
        public int number;

        public StudyStruct(int number) {
            this.number = number;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("Class START =========================");
        StudyClass myStudyClass = new StudyClass(10);
        StudyClass myStudyClass2 = myStudyClass;

        Debug.Log($"MyClass : {myStudyClass.number} / MyClass2 : {myStudyClass2.number}");

        myStudyClass.number = 100;
        Debug.Log($"MyClass : {myStudyClass.number} / MyClass2 : {myStudyClass2.number}");


        Debug.Log("STRUCT START =========================");
        StudyStruct myStudyStruct = new StudyStruct(10);
        StudyStruct studyStruct2 = myStudyStruct;
        Debug.Log($"MyStruct : {myStudyStruct.number} / MyStruct2 : {studyStruct2.number}");
        Debug.Log($"MyStruct : {myStudyStruct.number} / MyStruct2 : {studyStruct2.number}");
    }
}
