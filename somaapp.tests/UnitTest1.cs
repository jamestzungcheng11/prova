using NUnit.Framework;
using somaapppp;

namespace sommaapp
{

    public class ProgramTests
    {
        public void Soma_AdicionaDoisNumeros_Soma()
        {
            int x = 3;
            int y = 2;
            int expected = 5;

            int result = Program.Soma(x, y);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
