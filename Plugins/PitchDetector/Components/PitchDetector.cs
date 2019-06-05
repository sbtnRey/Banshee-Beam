using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace FinerGames.PitchDetector
{
    public class PitchDetector : MonoBehaviour
    {
        //public GameObject projectile;
        public AudioSource Source;
        public float Pitch;
        public int MidiNote;
        public int MidiCents;
        
        //public GameObject test;
        //public GameObject grad_0;

        public GameObject grad_1;
        public GameObject grad_2;
        public GameObject grad_3;
        public GameObject grad_4;
        public GameObject grad_5;
        public GameObject grad_6;
        public GameObject grad_7;
        public GameObject grad_8;
        public GameObject grad_9;
        public GameObject grad_10;
        public GameObject grad_11;
        public GameObject grad_12;
        public GameObject grad_13;
        
        //public GameObject projectile;

        public float delay;
        public float force;

        public Transform spawn;
        public float fireRate = 0.5F;
        private float nextFire = 0.0F;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {


            Debug.Log(Pitch);
            /*
            if (Pitch > 20 && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_1, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }
            */

            
            if ((Pitch > 20 && Pitch < 40) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_1, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 40 && Pitch < 62) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_1, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }


            if ((Pitch > 62 && Pitch < 84) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_2, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }


            if ((Pitch > 84 && Pitch < 106) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_3, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 106 && Pitch < 128) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_4, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }


            if ((Pitch > 128 && Pitch < 150) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_5, spawn.position,  spawn.rotation) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 150 && Pitch < 172) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_6, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 172 && Pitch < 195) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_7, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 195 && Pitch < 217) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_8, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 239 && Pitch < 261) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_9, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 261 && Pitch < 283) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_10, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 283 && Pitch < 305) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_11, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 305 && Pitch < 350) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_12, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }

            if ((Pitch > 350 && Pitch < 390) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject bullet = Instantiate(grad_13, transform.position,  Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Destroy(bullet, delay);
            }
            

        }
    }
}
