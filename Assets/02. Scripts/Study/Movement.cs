using UnityEngine;

public class Movement : MonoBehaviour {

    public float movespeed = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Debug.Log(this.transform.position);
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.W)) {
            this.transform.position += Vector3.forward * movespeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
            this.transform.position += Vector3.back * movespeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) {
            this.transform.position += Vector3.left * movespeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
            this.transform.position += Vector3.right * movespeed * Time.deltaTime;
        }
    }
}
