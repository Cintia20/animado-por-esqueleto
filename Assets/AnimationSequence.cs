using System.Collections;
using UnityEngine;

public class AnimationSequence : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        // Come�a a sequ�ncia de anima��es
        StartCoroutine(PlayAnimationSequence());
    }

    IEnumerator PlayAnimationSequence()
    {
        // Toca a anima��o de caminhar por 15 segundos
        animator.Play("walk");
        yield return new WaitForSeconds(15f);

        // Toca a anima��o de socar por 15 segundos
        animator.Play("hit");
        yield return new WaitForSeconds(15f);

        // Toca a anima��o de sentar por 15 segundos
        animator.Play("sitting");
        yield return new WaitForSeconds(15f);

        // Opcional: Reinicia a sequ�ncia ou finaliza.
        // StartCoroutine(PlayAnimationSequence());
    }
}