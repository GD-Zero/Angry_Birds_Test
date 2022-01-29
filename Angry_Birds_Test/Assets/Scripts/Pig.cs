using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Pig : MonoBehaviour
{
    [SerializeField] private float stamina = 1f; // выносливость свиньи
    //public UnityEvent PigAud;
    private void OnCollisionEnter2D(Collision2D collision) // метод для столкновения
    {
        //if (PigAud != null)
        //{
        //    PigAud.Invoke();
        //}
        if (collision.relativeVelocity.magnitude > stamina) // если сила удара больше, чем выносливость
        {
            Destroy(gameObject);// то объект удаляется
        }
    }
}
