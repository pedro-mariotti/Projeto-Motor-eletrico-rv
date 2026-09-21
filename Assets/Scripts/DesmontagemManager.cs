using UnityEngine;

public class DesmontagemManager : MonoBehaviour
{
    public int etapaAtual = 0;

    public void ConcluirEtapa()
    {
        etapaAtual++;

        // habilita próxima peça
    }
}