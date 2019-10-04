using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyMain.Data;
using FlyMain.Model;
using FlyMain.ViewModel;
using System.Linq;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Метод проверяет изменение баланса при покупке
        /// </summary>
        [TestMethod]
        public void TestMethodCalcBalance()
        {
            DataModel Data = new DataModel();//Генерация модели данных
            AirplaneModel airplane = Data.AirplaneList.First(); // берем первый самолет
            int price = airplane.Price;//берем стоимость самолета
            int balance = Data.Ballance;//берем баланс пользователя
            ShoopViewModel svm = new ShoopViewModel(Data);//Создали класс, отвечающий за покупку

            svm.ByAirplane(airplane.uid);
            Assert.IsNotNull(airplane);//проверка наличия самолета

            Assert.AreEqual(balance - price, svm.Data.Ballance);//проверка балланса

            svm.Data.Ballance = 10;
            svm.ByAirplane(airplane.uid);
            Assert.AreEqual(10, svm.Data.Ballance);//проверка балланса когда балланс меньше цены

        }
    }
}
