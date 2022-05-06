using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;
public class SwipeController : MonoBehaviour
{
    [SerializeField] private float _minSwipeDist = 100;

    private PlayerController _playerController;
    private LineChanger _lineChanger;
    private PlayerJump _playerJump;

    private Vector2 _startFingPos;

    private bool _onTap = false;

    private void Awake()
    {
        _lineChanger = GetComponent<LineChanger>();
        _playerJump = GetComponent<PlayerJump>();

        _playerController = GetComponent<PlayerController>();
    }
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
                if ((tap.position.y - _startFingPos.y) > _minSwipeDist * 2 && _onTap)
                {     
                    _onTap = false;
                    SwipeUp();                
                }
                else if ((tap.position.y - _startFingPos.y) < -_minSwipeDist * 2 && _onTap)
                {  
                        _onTap = false;
                        SwipeDown();
                }
                else if ((tap.position.x - _startFingPos.x) > _minSwipeDist && _onTap)
                {
                    _onTap = false;
                    SwipeRight();

                }
                else if ((tap.position.x - _startFingPos.x) < -_minSwipeDist && _onTap)
                {
                    _onTap = false;
                    SwipeLeft();
                }
            }

        }

    }

        private void SwipeUp()
        {
          _playerJump.Jump();
        }

        private void SwipeDown()
        {
          _playerController.Attack();         
        }

        private void SwipeRight()
        {
          _lineChanger.MoveRight();
        }

        private void SwipeLeft()
        {
          _lineChanger.MoveLeft();
        }
}
