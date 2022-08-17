using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabExercise;

namespace LabExercise

{
    [TestClass]
    public class MyCalcTest
    {
     [TestMethod]
        public void TestAddMethod()
        {
            double actualresult = MyCalc.Add(10,20);
            double expectedresult = 30;
            Assert.AreEqual(expectedresult,actualresult,"add method is failed ");
        }
         [TestMethod]
        public void TestsubMethod()
        {
            double actualresult = MyCalc.sub(10,20);
            double expectedresult = -10;
            Assert.AreEqual(expectedresult,actualresult,"sub method is failed ");
        }
        [DataTestMethod]
        [DataRow(10,20,30)]
        [DataRow(20,20,40)]
        [DataRow(30,30,60)]
        public void TestDataAddMethod(double op1,double op2,double exp)
        {
            double actualresult = MyCalc.Add(op1,op2);
            Assert.AreEqual(exp,actualresult,"add method is failed ");
        }
           [DataTestMethod]
           [DataRow(10,2,5)]
           [DataRow(20,5,4)]
           [DataRow(30,5,6)]
            public void TestDatadivMethod(int n1,int n2,int exp)
        {
            double actualresult = MyCalc.div(n1,n2);
            Assert.AreEqual(exp,actualresult,"div method is failed ");
        }
           [DataTestMethod]
           [DataRow(10,2,3)]
           [DataRow(20,5,5)]
           [DataRow(30,5,5)]
            public void NegativeTestdivMethod(int n1,int n2,int exp)
        {
            double actualresult = MyCalc.div(n1,n2);
            Assert.AreNotEqual(exp,actualresult,"div method is failed ");
        }
        [DataTestMethod]
        [DataRow(20,10,10)]
        [DataRow(50,30,20)]
        [DataRow(30,30,0)]
        public void TestDatasubMethod(double o1,double o2,double exp)
        {
            double actualresult = MyCalc.sub(o1,o2);
            Assert.AreEqual(exp,actualresult,"sub method is failed ");
        } 
        [DataTestMethod]
        [DataRow(20,10,0)]
        [DataRow(50,30,0)]
        [DataRow(30,30,20)]
        public void NegativeTestsubMethod(double o1,double o2,double exp)
        {
            double actualresult = MyCalc.sub(o1,o2);
            Assert.AreNotEqual(exp,actualresult,"sub method is failed ");
        } 
        [DataTestMethod]
        [DataRow(10,5,50)]
        [DataRow(5,3,15)]
        [DataRow(3,3,9)]
        public void TestDatamulMethod(double m1,double m2,double exp)
        {
            double actualresult = MyCalc.mul(m1,m2);
            Assert.AreEqual(exp,actualresult,"mul method is failed ");
        } 
        [DataTestMethod]
        [DataRow(10,5,0)]
        [DataRow(5,3,12)]
        [DataRow(3,3,12)]
        public void NegativeTestmulMethod(double m1,double m2,double exp)
        {
            double actualresult = MyCalc.mul(m1,m2);
            Assert.AreNotEqual(exp,actualresult,"mul method is failed ");
        } 
        [DataTestMethod]
        [DataRow(2,3,8)]
        [DataRow(3,3,27)]
        [DataRow(5,3,125)]
        public void TestDatapowMethod(int p1,int p2,int exp)
        {
            double actualresult = MyCalc.pow(p1,p2);
            Assert.AreEqual(exp,actualresult,"power method is failed ");
        } 
         [DataTestMethod]
        [DataRow(2,3,12)]
        [DataRow(3,3,28)]
        [DataRow(5,3,625)]
        public void NegativeTestDatapowMethod(int p1,int p2,int exp)
        {
            double actualresult = MyCalc.pow(p1,p2);
            Assert.AreNotEqual(exp,actualresult,"power method is failed ");
        } 
    }


}
