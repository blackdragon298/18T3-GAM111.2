using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
	NavMeshAgent myNav;
	Camera cam;
	Vector3 targetPos;
	GameObject manager;
	Animator animator;

	// Use this for initialization
	void Start()
	{
		manager = GameObject.Find("Manager");
		myNav = GetComponent<NavMeshAgent>();
		cam = Camera.main;
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Vector3.Distance(targetPos, this.transform.position) < 0.1f)
		{
			animator.SetFloat("MoveSpeed", 0.0f);
		}

		if (Input.GetMouseButtonDown(0))
		{
			SetDestination();
			animator.SetFloat("MoveSpeed", 1.0f);
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.DrawSphere(targetPos, 0.5f);
	}

	private void OnCollisionEnter(Collision collision)
	{
		GameObject other = collision.gameObject;

		if (other.CompareTag("Enemy"))
		{
			manager.GetComponent<SceneControl>().LoadCombat();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Grass"))
		{
			int randomBattle = Random.Range(0, 100);
			if (randomBattle > 95)
			{
				print("FIGHT!");
			}
		}
	}

	void SetDestination()
	{
		RaycastHit hit;

		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);

		if (Physics.Raycast(ray, out hit))
		{
			targetPos = hit.point;
			targetPos.y = this.transform.position.y;
			myNav.destination = targetPos;
		}
	}


}
