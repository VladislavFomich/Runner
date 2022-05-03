using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTutorial : MonoBehaviour
{
    [SerializeField] private GameObject _upTxt;
    [SerializeField] private GameObject _moveTxt;
    [SerializeField] private GameObject _attackTxt;

    [SerializeField] private GameObject _arrowUp;
    [SerializeField] private GameObject _arrowRight;
    [SerializeField] private GameObject _arrowLeft;
    [SerializeField] private GameObject _arrowDown;


    private int _triggerCount;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tutorial")) 
        {
            _triggerCount++;
            ViewSwipeUp();
            ViewMoveSwipe();
            ViewSwipeDown();
        }
    }
    private void ViewSwipeUp()
    {
        switch (_triggerCount)
        {
            case 1:
                _arrowUp.SetActive(true);
                _upTxt.SetActive(true);
                break;
            case 2:
            case 4:
            case 6:
                _arrowUp.SetActive(false);
                _upTxt.SetActive(false);
                break;
            case 3:
            case 5:
                _arrowUp.SetActive(true);
                _arrowUp.GetComponent<Animator>().SetTrigger("Up");
                break;

            default:
                break;
        }
    }
    private void ViewMoveSwipe()
        {
            switch (_triggerCount)
        {
            case 7:
                _arrowRight.SetActive(true);
                _arrowLeft.SetActive(true);
                _moveTxt.SetActive(true);
                break;
            case 8:
            case 10:
            case 12:
                _arrowRight.SetActive(false);
                _arrowLeft.SetActive(false);
                _moveTxt.SetActive(false);
                break;
            case 9:
                _arrowRight.SetActive(true);
                _arrowRight.GetComponent<Animator>().SetTrigger("Right");
                break;
            case 11:
                _arrowLeft.SetActive(true);
                _arrowLeft.GetComponent<Animator>().SetTrigger("Left");
                break;
        }
        
            
        }
    private void ViewSwipeDown()
    {
        switch (_triggerCount)
        {
            case 13:
                _arrowDown.SetActive(true);
                _attackTxt.SetActive(true);
                break;
            case 14:
            case 16:
            case 20:
                _arrowDown.SetActive(false);
                _attackTxt.SetActive(false);
                break;
            case 15:
            case 19:
                _arrowDown.SetActive(true);
                _arrowDown.GetComponent<Animator>().SetTrigger("Down");
                break;
        }
        }
}
