using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private Rigidbody2D _rigidbody;
   private bool _isFlying;
   [SerializeField] private Keys _keys;
   private static bool _isPlay = false;

    public bool IsFlying { get => _isFlying; set => _isFlying = value; }
    public static bool IsPlay { get => _isPlay; set => _isPlay = value; }

    private void Update() {
        if(Input.GetMouseButtonDown(0) && _isPlay)
        ChangePosition();
        
    }
    public void ChangePosition()
    {
        _isFlying =! _isFlying;
        if(_isFlying)
        {
        _rigidbody.gravityScale = -5;
        transform.localScale = new Vector3(1, -1, 1);
        }
        else
        {
        _rigidbody.gravityScale = 5;
        transform.localScale = new Vector3(1, 1, 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.TryGetComponent<Trap>(out Trap _trap))
        {
           _keys. EndGame();
        }
         if(other.TryGetComponent<Point>(out Point _point))
        {
          Wallet.ChangeMoney();
          Wallet.Score++;
          _keys.ChangeText(Wallet.Score);
        }
    }
}
