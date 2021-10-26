using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Note_Counter : MonoBehaviour
{
    public GameObject note1;
    public MeshRenderer note1Mesh;
    public GameObject note2;
    public MeshRenderer note2Mesh;
    public GameObject note3;
    public MeshRenderer note3Mesh;
    public GameObject note4;
    public MeshRenderer note4Mesh;
    public GameObject note5;
    public MeshRenderer note5Mesh;
    public GameObject note6;
    public MeshRenderer note6Mesh;
    public GameObject note7;
    public MeshRenderer note7Mesh;

    private void OnTriggerEnter(Collider other)
    {
        note1Mesh.material.SetColor("White", Color.white);
        note2Mesh.material.SetColor("White", Color.white);
        note3Mesh.material.SetColor("White", Color.white);
        note4Mesh.material.SetColor("White", Color.white);
        note5Mesh.material.SetColor("White", Color.white);
        note6Mesh.material.SetColor("White", Color.white);
        note7Mesh.material.SetColor("White", Color.white);

        SceneManager.LoadScene("Win Screen");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
