using System.Collections;
using System.Collections.Generic;
using Oculus.Platform.Samples.VrHoops;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_Manager : MonoBehaviour
{
 //Declare public variables to access throughout scene
 public GameObject playerobject;
 
 public static scene_Manager Instance { get; private set; }

 private void Awake()
 {
  
  if (Instance == null)
  {
   Instance = this;
  }
  else
  {
   Destroy(gameObject);
  }
 }
}
