using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damage = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target1"))
        {
            collision.gameObject.SendMessage("OnDamage", damage);
        }
    }
}
