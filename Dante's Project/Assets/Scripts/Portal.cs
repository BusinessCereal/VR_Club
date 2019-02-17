using UnityEngine;
using System.Collections;
using Oculus.Platform.Samples.VrHoops;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
 
public Transform Destination;       // Gameobject where they will be teleported to
private Vector3 debugdestination = new Vector3(-284.97f,0f,-93.17f);
private GameObject _player;

// Use this for initialization
void Start ()
{
    _player = scene_Manager.Instance.playerobject;

}

public void OnTriggerEnter(Collider other)
{
// If the tag of the colliding object is allowed to teleport
    if (other.gameObject.CompareTag("Player"))
    {
        Debug.Log("its time to TP");
       // _player.transform.position = Destination.position;
       _player.transform.position = debugdestination;
    }

// Update other objects position and rotation
    
}
}