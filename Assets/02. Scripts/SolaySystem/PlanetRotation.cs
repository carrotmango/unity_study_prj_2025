using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform tragetPlaent;
    public float rotSpeed = 30f;
    public float revolutionSpeed = 100f;
    public bool isRevolution = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        
            //자기자신 회전
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);


        if (isRevolution) { //만약 공전한다면
            //공전하는 기능
            transform.RotateAround(tragetPlaent.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }

    }
}
