using UnityEngine;

public class RouletteController : MonoBehaviour {
    public float rotSpeed;
    public bool isStop;

    void Start() {
        rotSpeed = 0f;
    }

    void Update() {
        transform.Rotate(Vector3.forward * rotSpeed); // Z�� �������� ȸ���ϴ� ���

        // ���콺 ���� ��ư�� ������ �� ȸ���ϴ� ���
        if (Input.GetMouseButtonDown(0)) {
            rotSpeed = 5f;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {

            isStop = true;
        }

        if (isStop == true) {
            rotSpeed *= 0.98f;
            if (rotSpeed < 0.01f) {
                rotSpeed = 0f;
            }
        }

    }
}
