using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
   private void Start() {
       Destroy(gameObject, 15f);
   } 
  private void Update() {
      if(Player.IsPlay)
      transform.Translate(Vector2.left * Spawner.Speed);
  }
}
