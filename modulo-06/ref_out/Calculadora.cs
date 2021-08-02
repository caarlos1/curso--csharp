namespace ref_out
{
    public class Calculadora
    {
        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }
        public static void Quadriplicar(int origem, out int resultado)
        {
            resultado = origem * 4;
        }
    }
}