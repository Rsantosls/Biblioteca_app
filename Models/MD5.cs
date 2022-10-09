using System;
 
public static class MD5Hash
{
    /// <summary>
    /// Calcula MD% Hash de uma determinada string passada como parametro
    /// </summary>
    /// <param name="Senha">String contendo a senha que deve ser criptografada para MD5 Hash</param>
    /// <returns>string com 32 caracteres com a senha criptografada</returns>

    public static string senhaHash(string Senha)
    {
        try
        {
            // Criação do objeto MD5
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            // Vetor que recebe o parametro transformado em bytes
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Senha);
            // Vetor que salva o parametro em formato MD5
            byte[] hash = md5.ComputeHash(inputBytes);
            // 
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString(); // Retorna senha criptografada 
        }
        catch (Exception)
        {
            return null; // Caso encontre erro retorna nulo
        }
    }
}