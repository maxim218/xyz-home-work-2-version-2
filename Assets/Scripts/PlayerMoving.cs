using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {
    private float _directionX = 0f;
    private float _directionY = 0f;
    
    public void SetDirectionX(float value) {
        _directionX = value;
    }

    public void SetDirectionY(float value) {
        _directionY = value;
    }

    [SerializeField] private float speedX = 0f;
    [SerializeField] private float speedY = 0f;

    private void Update() {
        transform.Translate(_directionX * speedX * Time.deltaTime, _directionY * speedY * Time.deltaTime, 0);
    }
}
