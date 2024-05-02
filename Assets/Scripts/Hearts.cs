using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    [SerializeField]int valueLife;
    [SerializeField] HandlerHealtSO HHSO;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HHSO.ModifyLife(valueLife);
            //HealthSystem.modifyHealth?.Invoke(valueLife);
        }
    }
}
