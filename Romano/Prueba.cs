using CalidadT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romano
{
    public class Prueba
    {
        [Test]
        public void caso01Romano()
        {
            //Numero Romano de 1 = I
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(1);
            Assert.AreEqual("I", ob);
        }

        [Test]
        public void caso02Romano()
        {
            //Numero Romano de 3 = III
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(3);
            Assert.AreEqual("III", ob);
        }

        [Test]
        public void caso03Romano()
        {
            //Numero Romano de 5 = V
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(5);
            Assert.AreEqual("V", ob);
        }

        [Test]
        public void caso04Romano()
        {
            //Numero Romano de 10 = X
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(10);
            Assert.AreEqual("X", ob);
        }

        [Test]
        public void caso05Romano()
        {
            //Numero Romano de 30 = XXX
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(30);
            Assert.AreEqual("XXX", ob);
        }

        [Test]
        public void caso06Romano()
        {
            //Numero Romano de 50 = L
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(50);
            Assert.AreEqual("L", ob);
        }

        [Test]
        public void caso07Romano()
        {
            //Numero Romano de 100 = C
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(100);
            Assert.AreEqual("C", ob);
        }

        [Test]
        public void caso08Romano()
        {
            //Numero Romano de 125 = CXXV
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(125);
            Assert.AreEqual("CXXV", ob);
        }

        [Test]
        public void caso09Romano()
        {
            //Numero Romano de 187 = CLXXXVII
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(187);
            Assert.AreEqual("CLXXXVII", ob);
        }

        [Test]
        public void caso10Romano()
        {
            //Numero Romano de 250 = CCL
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(250);
            Assert.AreEqual("CCL", ob);
        }

        [Test]
        public void caso11Romano()
        {
            //Numero Romano de 375 = CCCLXXV
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(375);
            Assert.AreEqual("CCCLXXV", ob);
        }

        [Test]
        public void caso12Romano()
        {
            //Numero Romano de 432 = CDXXXII
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(432);
            Assert.AreEqual("CDXXXII", ob);
        }

        [Test]
        public void caso13Romano()
        {
            //Numero Romano de 500 = D
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(500);
            Assert.AreEqual("D", ob);
        }

        [Test]
        public void caso14Romano()
        {
            //Numero Romano de 602 = DCII
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(602);
            Assert.AreEqual("DCII", ob);
        }

        [Test]
        public void caso15Romano()
        {
            //Numero Romano de 625 = DCXXV
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(625);
            Assert.AreEqual("DCXXV", ob);
        }

        [Test]
        public void caso16Romano()
        {
            //Numero Romano de 750 = DCCL
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(750);
            Assert.AreEqual("DCCL", ob);
        }

        [Test]
        public void caso17Romano()
        {
            //Numero Romano de 812 = DCCCXII
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(812);
            Assert.AreEqual("DCCCXII", ob);
        }

        [Test]
        public void caso18Romano()
        {
            //Numero Romano de 875 = DCCCLXXV
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(875);
            Assert.AreEqual("DCCCLXXV", ob);
        }

        [Test]
        public void caso19Romano()
        {
            //Numero Romano de 900 = CM
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(900);
            Assert.AreEqual("CM", ob);
        }

        [Test]
        public void caso20Romano()
        {
            //Numero Romano de 925 = CMXXV
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(925);
            Assert.AreEqual("CMXXV", ob);
        }

        [Test]
        public void caso21Romano()
        {
            //Numero Romano de 950 = CML
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(950);
            Assert.AreEqual("CML", ob);
        }

        [Test]
        public void caso22Romano()
        {
            //Numero Romano de 970 = CMLXX
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(970);
            Assert.AreEqual("CMLXX", ob);
        }

        [Test]
        public void caso23Romano()
        {
            //Numero Romano de 990 = CMXC
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(990);
            Assert.AreEqual("CMXC", ob);
        }

        [Test]
        public void caso24Romano()
        {
            //Numero Romano de 995 = CMXCV
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(995);
            Assert.AreEqual("CMXCV", ob);
        }

        [Test]
        public void caso25Romano()
        {
            //Numero Romano de 1000 = M
            var romanoGenerator = new RomanoGenerator();
            var ob = romanoGenerator.GetRomano(100);
            Assert.AreEqual("M", ob);
        }
    }
}
