using System.Collections;
using UnityEngine;

public class AnimationSequence : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        // Começa a sequência de animações
        StartCoroutine(PlayAnimationSequence());
    }

    IEnumerator PlayAnimationSequence()
    {
        // Toca a animação de caminhar por 15 segundos
        animator.Play("walk");
        yield return new WaitForSeconds(15f);

        // Toca a animação de socar por 15 segundos
        animator.Play("hit");
        yield return new WaitForSeconds(15f);

        // Toca a animação de sentar por 15 segundos
        animator.Play("sitting");
        yield return new WaitForSeconds(15f);

        // Opcional: Reinicia a sequência ou finaliza.
        // StartCoroutine(PlayAnimationSequence());
    }
}