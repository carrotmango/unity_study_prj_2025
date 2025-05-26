using UnityEngine;

public class StudyTransform : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()

            {
        // 월드 방향으로 이동
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 방향으로 이동
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 월드 방향을 이동
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        // 월드 방향으로 회전
        transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

        // 로컬 방향으로 회전
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략

        // 월드 방향으로 회전
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // 특정 위치의 주변을 회전
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);

        // 특정 위치를 바라보며 회전
        transform.LookAt(Vector3.zero);
    }

    //{
    //    //vector3.ford는 월드 방향으로 이동하는 기능이다
    //    //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

    //    //월드 방향으로 이동
    //    //transform.localPosition += Vector3.forward * moveSpeed * Time.deltaTime;

    //    //로컬방향으로 이동하는 기능
    //    //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

    //    //월드 방향으로 회전

    //    //float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
    //    //float localX = transform.rotation.eulerAngles.x;
    //    //float localZ = transform.rotation.eulerAngles.z;

    //    //transform.rotation = Quaternion.Euler(localX, angle, localZ);

    //    //transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

    //    //// 로컬 방향으로 회전
    //    //transform.localRotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

    //    // 로컬 방향으로 회전
    //    //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략

    //    //// 월드 방향으로 회전
    //    //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

    //    //vector Zero는 (0,0,0) Vector.one = 1f,1f,1f, Vector.up (0f, 1f, 0f)
    //    transform.RotateAround(Vector3.zero, new Vector3(0f, 1f, 0f), rotateSpeed * Time.deltaTime);

    //    transform.LookAt(Vector3.zero);
    //}

}
