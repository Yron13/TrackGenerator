using UnityEngine;

namespace Assets.TrackPieces
{
    public abstract class TrackPiece : MonoBehaviour
    {
        public void Place( Transform pos)
        {
            gameObject.transform.position = pos.position;
            gameObject.transform.rotation = pos.rotation;

            Vector3 offset = pos.rotation * getOffset();
            pos.position = pos.position + offset;
            pos.rotation = pos.rotation * getRotation();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("OnCollisionEnter2D");
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("OnTriggerEnter2D");
        }
      
        protected static Vector3 offset = new Vector3(0, 1, 0);
        protected Quaternion rotation = Quaternion.identity;


        private Transform end;


        protected abstract Shape GetShape();
        protected abstract Quaternion getRotation();
        protected abstract Vector3 getOffset();        
    }
}