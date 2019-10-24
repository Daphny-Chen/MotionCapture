using UnityEngine;

public class Player : MonoBehaviour {

    private Animator Rot;

    // Use this for initialization
    void Start () {

        Rot = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) Rot.SetTrigger("dance");

        Rot.SetBool("run", Input.GetKey(KeyCode.R));
	}
}
