using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Configura��es")]
    public Transform target;   // Player
    public float smoothSpeed = 5f; // Suavidade do movimento
    public Vector3 offset;     // Dist�ncia da c�mera para o player

    void LateUpdate()
    {
        if (target == null) return;

        // Posi��o desejada (alvo + offset)
        Vector3 desiredPosition = target.position + offset;

        // Movimento suave (Lerp)
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Atualiza posi��o da c�mera
        transform.position = smoothedPosition;
    }
}
