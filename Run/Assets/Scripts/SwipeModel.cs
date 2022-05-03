using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeModel : MonoBehaviour
{
    [SerializeField] private Transform[] _modelTransforms;
    [SerializeField] private float _minSwipeDist = 100;

    [SerializeField] private float _speed;
    private Vector2 _startFingPos;
    private Vector3 _newPosition;
  
    private bool _onTap = false;
    private bool _isRight;
    private bool _isLeft;

    private int _position = 0;
    public int Position { get => _position; }
    void Update()
    {
        if (Input.touches.Length > 0)
        {
            Touch tap = Input.touches[0];
            if (tap.phase == TouchPhase.Began)
            {
                _onTap = true;
                _startFingPos = tap.position;
            }

            if (tap.phase == TouchPhase.Moved)
            {
                if ((tap.position.x - _startFingPos.x) > _minSwipeDist && _onTap)
                {
                    _onTap = false;
                    if (_position != 0)
                    {
                      _isRight = true;
                    }
                }
                else if ((tap.position.x - _startFingPos.x) < -_minSwipeDist && _onTap)
                {
                    _onTap = false;
                    if (_position != _modelTransforms.Length - 1)
                    {
                        _isLeft = true;
                    }
                }
            }
        }
        if (_isRight)
        {
            SwipeRight();
        }
        if (_isLeft)
        {
            SwipeLeft();;
        }
        if (transform.position == _newPosition)
        {
            if (_isRight)
            {
                _position -= 1;
            }
            else if (_isLeft)
            {
                _position += 1;
            }
            _isRight = false;
            _isLeft = false;
        }
    }

    public void SwipeRight()
    {
        _newPosition = new Vector3(_modelTransforms[_position - 1].position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position,_newPosition, Time.deltaTime * _speed);
    }
    public void SwipeLeft()
    {
        _newPosition = new Vector3(_modelTransforms[_position + 1].position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position,_newPosition, Time.deltaTime * _speed);
    }
}
