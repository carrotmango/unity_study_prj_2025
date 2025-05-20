using System;
using UnityEngine;

namespace dev.mango {
    public class StudyLog : MonoBehaviour {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start() {
            Debug.Log("START_일반");
            Debug.LogWarning("START_경고");
            Debug.LogError("START_에러");
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
