using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Obtener el componente Animator del objeto
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Detectar las teclas y activar las animaciones correspondientes
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("stretching");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("slowdancing");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("dancing");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("breakdancing");
        }
    }
}


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
