// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class Plane : SceneEntity
{
    [SerializeField] private Vector3 center;
    [SerializeField] private Vector3 normal;
    
    public Vector3 Center => this.center;
    public Vector3 Normal => this.normal;
    
    public override RaycastHit? Intersect(Ray ray)
    {
        // By default we use the Unity engine for ray-entity collisions.
        // See the parent 'SceneEntity' class definition for details.
        // Task: Replace with your own intersection computations.
        // return base.Intersect(ray);

        float DdotN = Vector3.Dot(ray.direction, Normal);
        if (DdotN == 0)
        {
            return null;
        }

        float t = Vector3.Dot((Center - ray.origin), Normal);
        t /= Vector3.Dot(ray.direction, Normal);

        if (t > 0)
        {
            RaycastHit isHit = new RaycastHit();
            isHit.distance = t;
            return isHit;
        }

        return null;
    }
}
