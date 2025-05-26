using UnityEngine;

public class StudyTransform : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()

            {
        // ���� �������� �̵�
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // ���� �������� �̵�
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // ���� ������ �̵�
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        // ���� �������� ȸ��
        transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

        // ���� �������� ȸ��
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self ����

        // ���� �������� ȸ��
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // Ư�� ��ġ�� �ֺ��� ȸ��
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);

        // Ư�� ��ġ�� �ٶ󺸸� ȸ��
        transform.LookAt(Vector3.zero);
    }

    //{
    //    //vector3.ford�� ���� �������� �̵��ϴ� ����̴�
    //    //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

    //    //���� �������� �̵�
    //    //transform.localPosition += Vector3.forward * moveSpeed * Time.deltaTime;

    //    //���ù������� �̵��ϴ� ���
    //    //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

    //    //���� �������� ȸ��

    //    //float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
    //    //float localX = transform.rotation.eulerAngles.x;
    //    //float localZ = transform.rotation.eulerAngles.z;

    //    //transform.rotation = Quaternion.Euler(localX, angle, localZ);

    //    //transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

    //    //// ���� �������� ȸ��
    //    //transform.localRotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

    //    // ���� �������� ȸ��
    //    //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self ����

    //    //// ���� �������� ȸ��
    //    //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

    //    //vector Zero�� (0,0,0) Vector.one = 1f,1f,1f, Vector.up (0f, 1f, 0f)
    //    transform.RotateAround(Vector3.zero, new Vector3(0f, 1f, 0f), rotateSpeed * Time.deltaTime);

    //    transform.LookAt(Vector3.zero);
    //}

}
