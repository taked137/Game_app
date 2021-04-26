using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using festival.battle;

namespace packt.FoodyGO.PhysicsExt
{
    public class CollisionMonsterReaction : MonoBehaviour
    {
        public string collisionObjectName;
        public Transform particlePrefab;
        public float destroyParticleDelaySeconds;
        public bool destroyObject;
        public float destroyObjectDelaySeconds;

        private GameObject BattleSceneObject;

        void Start()
        {
        }

        public void OnCollisionReaction(GameObject go, Collision collision)
        {
            Debug.Log("OnCollisionReaction");

            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;

            if (particlePrefab != null)
            {
                var particle = (Transform)Instantiate(particlePrefab, pos, rot);
                Destroy(particle.gameObject, destroyParticleDelaySeconds);
            }
            if (destroyObject)
            {
                Destroy(go, destroyObjectDelaySeconds);
            }

            BattleSceneObject.GetComponent<EnemyController>().OnMonsterHit();
        }

        public void SetBattleSceneObject()
        {
            BattleSceneObject = GameObject.Find("BattleScene");
        }        
    }

}

