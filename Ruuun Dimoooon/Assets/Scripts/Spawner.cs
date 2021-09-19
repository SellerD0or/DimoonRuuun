using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int _money;
    [SerializeField]private GameObject[] _traps;
    [SerializeField] private GameObject[] _pos;
    private static float _speed = 0.06f;

    public static float Speed { get => _speed; set => _speed = value; }
 

    private void Start() {
      StartCoroutine(Spawn());
  }
  private IEnumerator Spawn()
  {
     int t = Random.Range(2, 5);
      yield return new WaitForSeconds(t);
      if(Player.IsPlay)
      {
      Speed += 0.03f * Time.deltaTime;
      int r = Random.Range(0, _traps.Length);
      Instantiate(_traps[r], _pos[r].transform.position,Quaternion.identity);
      }
       
      StartCoroutine(Spawn());
  }
}
