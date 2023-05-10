using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
 public class BallBehavouire : MonoBehaviour
 {   
    [SerializeField] private float m_MovePower = 100; // The force added to the ball to move it.
    [SerializeField] private bool m_UseTorque = true; // Whether or not to use torque to move the ball.
    [SerializeField] private float m_MaxAngularVelocity = 2000; // The maximum velocity the ball can rotate at.
    [SerializeField] private float m_JumpPower = 30; // The force added to the ball when it jumps.

    private const float k_GroundRayLength = 1f; // The length of the ray to check if the ball is grounded.
    private Rigidbody m_Rigidbody;
      
    public Transform plChar;
    public int threshold;
    public int power;
 
 private void Update(){
     if((transform.position - plChar.transform.position).magnitude < threshold && Input.GetKeyDown("t")) {
     m_Rigidbody.AddForce((transform.position - plChar.transform.position).normalized * power); 
 }
 }

        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
            GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }


        public void Move(Vector3 moveDirection, bool jump)
        {
            
            if (m_UseTorque)
            {
                m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x)*m_MovePower);
            }
            else
            {
                m_Rigidbody.AddForce(moveDirection*m_MovePower);
            }

            if (Physics.Raycast(transform.position, -Vector3.up, k_GroundRayLength) && jump)
            {
                m_Rigidbody.AddForce(Vector3.up*m_JumpPower, ForceMode.Impulse);
            }
        }
     
     
 }
