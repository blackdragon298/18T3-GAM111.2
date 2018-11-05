using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class fido : MonoBehaviour
{

	NavMeshAgent myNav;
	Transform tennisBall;
	Camera cam;

	Vector3 targetPos;
	// Use this for initialization
	void Start()
	{
		myNav = GetComponent<NavMeshAgent>();
		//tennisBall = GameObject.Find("TennisBall").transform;
		cam = Camera.main;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			SetDestination(); 
		}
		
		//myNav.destination = tennisBall.position;
	}

	void SetDestination()
	{
		RaycastHit hit;

		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);

		if (Physics.Raycast(ray, out hit))
		{
			targetPos = hit.point;
			myNav.destination = targetPos;
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.DrawSphere(targetPos, 0.5f);
	}
}
