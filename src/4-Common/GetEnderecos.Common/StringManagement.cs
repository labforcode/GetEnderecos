namespace GetEnderecos.Common
{
    public static class StringManagement
    {

        /// <summary>
        /// Converte o valor em string para texto minusculo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ConverterTextoMinusculo(string value)
        {
            return value.ToLower();
        }

        /// <summary>
        /// Converte o valor em strinf para texto maiusculo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ConverterTextoMaiusculo(string value)
        {
            return value.ToUpper();
        }

        /// <summary>
        /// Remover caracteres acentuados
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string RemoverCaracteresEspeciaisTexto(string texto)
        {
            //byte[] tempBytes;
            //tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(texto);
            //return System.Text.Encoding.UTF8.GetString(tempBytes);
            return texto;
        }
    }
}
