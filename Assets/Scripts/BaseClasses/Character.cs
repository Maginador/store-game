using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   public float speed;
   public int health;
   private const float Threshold = 0.1f;
   private Coroutine _moveRoutine;
   
   public void Move(Vector3 targetPos)
   {
      if(!(_moveRoutine is null)) StopCoroutine(_moveRoutine);
      _moveRoutine = StartCoroutine(MoveRoutine(targetPos));
   }

   private IEnumerator MoveRoutine(Vector3 targetPos)
   {
      var originalPosition = transform.position;
      while (Vector3.Distance(transform.position,targetPos) > Threshold)
      {
         transform.position += (targetPos - originalPosition).normalized*speed;
         yield return null;

      }
   }

   public void DoDamage(int damage)
   {
      health -= damage;
   }
}
