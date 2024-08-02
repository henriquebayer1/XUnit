using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculos.Teste
{
    public class CalculoUnitTest
    {

        [Fact]
        public void Test1()
        {

            var x1 = 10;
            var x2 = 5;
            var valorEsperadoS = 15;
          
            //Act

            var soma = Class1.Somar(x1, x2);
          

            //Assert - Provar
            Assert.Equal(valorEsperadoS, soma);
            

        }


        [Fact]
        public void Test2()
        {

            var x1 = 10;
            var x2 = 5;
           
            var valorEsperadoSu = 5;
            

            //Act

           
            var subtracao = Class1.Subtracao(x1, x2);
            
            //Assert - Provar
          
            Assert.Equal(valorEsperadoSu, subtracao);
           
        }


        [Fact]
        public void Test3()
        {

            var x1 = 10;
            var x2 = 5;
           
            var valorEsperadoD = 2;
          
            //Act

           
            var divisao = Class1.Divisao(x1, x2);
            

            //Assert - Provar
           
            Assert.Equal(valorEsperadoD, divisao);
         

        }


        [Fact]
        public void Test4()
        {

            var x1 = 10;
            var x2 = 5;
            
            var valorEsperadoM = 50;

            //Act

           
            var multiplicacao = Class1.Multiplicacao(x1, x2);

            //Assert - Provar
          
            Assert.Equal(valorEsperadoM, multiplicacao);

        }


        [Fact]
        public void VerifyEmail()
        {
            string email = "henrique@gmail.com";

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            Assert.True(match.Success, email);
        }



        [Fact]
        public void TestCelciusFareight()
        {

            var c = 30;
           
          var result =  Class1.CelciusFareight(c);

            var valorEsperadoD = 86;

          


            //Assert - Provar

            Assert.Equal(valorEsperadoD, result);


        }
    }
}
