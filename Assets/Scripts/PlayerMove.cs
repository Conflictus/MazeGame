using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения персонажа
    private Rigidbody2D rb; // Компонент Rigidbody2D

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Получаем компонент Rigidbody2D
    }

    void Update()
    {
        // Получаем ввод с клавиш WASD
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D или стрелки влево/вправо
        float moveY = Input.GetAxisRaw("Vertical");   // W/S или стрелки вверх/вниз
        // Вычисляем вектор движения с учетом изометрии
        Vector2 movement = new Vector2(moveX, moveY * 0.5f).normalized * moveSpeed;

        // Применяем движение к Rigidbody2D
        rb.linearVelocity = movement;
    }
}